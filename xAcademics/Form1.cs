using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace xAcademics
{
    public partial class Form1 : Form
    {
        private List<Section> _sections;
        private Image campusMap;

        public Form1()
        {
            InitializeComponent();
            LoadSchedule();
            LoadCampusMap();
        }

        
        private void LoadSchedule()
        {
            string filePath = Path.Combine(Application.StartupPath, "Term Schedule 251.xlsx");
            ScheduleReader reader = new ScheduleReader(filePath);
            _sections = reader.ReadSections();

            if (_sections.Count == 0)
            {
                MessageBox.Show("No sections loaded from Excel file.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadCampusMap()
        {
            try
            {
                string imagePath = Path.Combine(Application.StartupPath, "KFUPM Map1.png");
                campusMap = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load campus map: " + ex.Message);
            }

        }

        private void ShowRouteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string crnInput = CRNTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(crnInput))
                {
                    MessageBox.Show("Please enter at least one CRN.");
                    return;
                }

                if (DayComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a day.");
                    return;
                }

                //  Parse CRNs
                    List<string> enteredCRNs = crnInput
                   .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(c => c.Trim())
                   .ToList(); ;

                string selectedDay = DayComboBox.SelectedItem.ToString();

                var filteredSections = _sections
                .Where(s => enteredCRNs
                 .Any(crn => crn.Equals(s.getCRN().Trim(), StringComparison.OrdinalIgnoreCase))
                   && s.getSchedule().getDays().Contains(selectedDay))
                   .OrderBy(s => s.getSchedule().getStartTime())
                 .ToList();


                if (filteredSections.Count == 0)
                {
                    MessageBox.Show("No classes found for the entered CRNs on that day.",
                        "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DrawRoute(filteredSections);


                DayLabel.Text = $"Selected Day: {selectedDay}";
                CourseCountLabel.Text = $"Courses: {filteredSections.Count}";
                CoursesListBox.Items.Clear();
                for (int i = 0; i < filteredSections.Count; i++)
                {
                    var sec = filteredSections[i];
                    CoursesListBox.Items.Add($"{i + 1}- {sec.getCourse().getCode()}: {sec.getCourse().getName()}");
                }

                int uniqueBuildings = filteredSections.Select(s => s.getBuilding().getBuildingNumber()).Distinct().Count();
                BuildingCountLabel.Text = $"Buildings: {uniqueBuildings}";

                // Fake distance for now (later you can calculate using coordinates)
                //double fakeDistance = (uniqueBuildings - 1) * 0.6; // 0.6 km between each
               //DistanceLabel.Text = $"Distance: {fakeDistance:F1} km";


                string fullDayName = "";

                switch (selectedDay)
                {
                    case "U": fullDayName = "Sunday"; break;
                    case "M": fullDayName = "Monday"; break;
                    case "T": fullDayName = "Tuesday"; break;
                    case "W": fullDayName = "Wednesday"; break;
                    case "R": fullDayName = "Thursday"; break;
                    default: fullDayName = "Unknown"; break;
                }

                DayLabel.Text = $"Selected Day: {fullDayName}";

                CourseCountLabel.Text = $"Courses: {filteredSections.Count}";

                CoursesListBox.Items.Clear();
                for (int i = 0; i < filteredSections.Count; i++)
                {
                    var sec = filteredSections[i];
                    CoursesListBox.Items.Add($"{i + 1}- {sec.getCourse().getCode()}: {sec.getCourse().getName()}");
                }


                //  int 
                uniqueBuildings = filteredSections
    .Select(s => s.getBuilding().getBuildingNumber())
    .Distinct()
    .Count();



                BuildingCountLabel.Text = $"Buildings: {uniqueBuildings}";

               
                //fakeDistance = (uniqueBuildings - 1) * 0.6; // since we have no actual distance
                //DistanceLabel.Text = $"Distance: {fakeDistance:F1} km";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering or drawing route: " + ex.Message);
            }
        }
        private void DrawRoute(List<Section> sections)
        {
            Graphics g = DrawingPanel.CreateGraphics();
            g.Clear(Color.White);

            if (campusMap != null)
                g.DrawImage(campusMap, 0, 0, DrawingPanel.Width, DrawingPanel.Height);

            Pen routePen = new Pen(Color.Red, 3)
            {
                EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
            };
            Brush textBrush = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 9, FontStyle.Bold);

            var knownSections = sections.Where(s => s.getBuilding().hasKnownLocation()).ToList();

            if (knownSections.Count < 2)
            {
                MessageBox.Show("Not enough buildings with known coordinates to draw route.", "Notice");
                return;
            }

            DrawingPanel.MouseClick += (s, e) =>
            {
                MessageBox.Show($"Clicked at: X={e.X}, Y={e.Y}");
            };

            var orderedSections = knownSections
                .OrderBy(s => s.getSchedule().getStartTime())
                .ToList();

            var points = orderedSections
                .Select(s => s.getBuilding().getLocation())
                .ToList();

            DistanceCalculator calculator = new DistanceCalculator();
            double meters = calculator.CalculateDistance(points);
            DistanceLabel.Text = $"Distance: {meters:F1} m";

            for (int i = 0; i < points.Count - 1; i++)
            {
                g.DrawLine(routePen, points[i], points[i + 1]);
            }

            for (int i = 0; i < points.Count; i++)
            {
                var p = points[i];
                var sec = orderedSections[i];
                string label = $"{i + 1} ({sec.getBuilding().getBuildingNumber()})";

                g.FillEllipse(Brushes.Yellow, p.X - 8, p.Y - 8, 16, 16);
                g.DrawEllipse(Pens.DarkRed, p.X - 8, p.Y - 8, 16, 16);
                g.DrawString(label, font, textBrush, p.X - 10, p.Y - 25);
            }
            g.DrawString("Student Route for Selected Day", new Font("Arial", 12, FontStyle.Bold),
                Brushes.Black, 10, 10);
        }

    }
}
