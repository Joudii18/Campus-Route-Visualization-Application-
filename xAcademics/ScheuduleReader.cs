using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace xAcademics
{
    internal class ScheduleReader
    {
        private readonly string _filePath;

        public ScheduleReader(string filePath)
        {
            _filePath = filePath;
        }

        public List<Section> ReadSections()
        {
            List<Section> sections = new List<Section>();
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                workbook = excelApp.Workbooks.Open(_filePath);
                worksheet = (Excel.Worksheet)workbook.Worksheets[1];
                Excel.Range usedRange = worksheet.UsedRange;
                int rowCount = usedRange.Rows.Count;

                
                for (int row = 2; row <= rowCount; row++)
                {
                    
                    string crn = worksheet.Cells[row, 2].Value?.ToString();
                    string courseCode = worksheet.Cells[row, 3].Value?.ToString();
                    string sectionNumber = worksheet.Cells[row, 5].Value?.ToString();
                    string courseName = worksheet.Cells[row, 6].Value?.ToString();
                    string days = worksheet.Cells[row, 8].Value?.ToString();
                    string startTime = worksheet.Cells[row, 9].Value?.ToString();
                    string endTime = worksheet.Cells[row, 10].Value?.ToString();
                    string buildingNumber = worksheet.Cells[row, 11].Value?.ToString();

                   
                    if (string.IsNullOrWhiteSpace(crn) || string.IsNullOrWhiteSpace(buildingNumber))
                        continue;

                 
                    Course course = new Course(courseCode, courseName);
                    Schedule schedule = new Schedule(days, startTime, endTime);
                    Building building = new Building(buildingNumber);
                    Section section = new Section(crn, sectionNumber, course, schedule, building);

                    sections.Add(section);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading schedule file: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                workbook?.Close(false);
                excelApp.Quit();
            }

            return sections;
        }
    }
}
