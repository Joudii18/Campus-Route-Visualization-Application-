namespace xAcademics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CRNTextBox = new TextBox();
            DayComboBox = new ComboBox();
            ShowRouteButton = new Button();
            DrawingPanel = new Panel();
            DayLabel = new Label();
            CourseCountLabel = new Label();
            CoursesListBox = new ListBox();
            BuildingCountLabel = new Label();
            DistanceLabel = new Label();
            SuspendLayout();
            // 
            // CRNTextBox
            // 
            CRNTextBox.Location = new Point(148, 66);
            CRNTextBox.Name = "CRNTextBox";
            CRNTextBox.PlaceholderText = "Enter CRNs seperated by commas";
            CRNTextBox.Size = new Size(817, 23);
            CRNTextBox.TabIndex = 0;
            // 
            // DayComboBox
            // 
            DayComboBox.FormattingEnabled = true;
            DayComboBox.Items.AddRange(new object[] { "U", "M", "T", "W", "R" });
            DayComboBox.Location = new Point(663, 156);
            DayComboBox.Name = "DayComboBox";
            DayComboBox.Size = new Size(121, 23);
            DayComboBox.TabIndex = 1;
            // 
            // ShowRouteButton
            // 
            ShowRouteButton.Location = new Point(148, 106);
            ShowRouteButton.Name = "ShowRouteButton";
            ShowRouteButton.Size = new Size(104, 23);
            ShowRouteButton.TabIndex = 2;
            ShowRouteButton.Text = "Show Route";
            ShowRouteButton.UseVisualStyleBackColor = true;
            ShowRouteButton.Click += ShowRouteButton_Click;
            // 
            // DrawingPanel
            // 
            DrawingPanel.Location = new Point(53, 156);
            DrawingPanel.Name = "DrawingPanel";
            DrawingPanel.Size = new Size(419, 370);
            DrawingPanel.TabIndex = 3;
            // 
            // DayLabel
            // 
            DayLabel.AutoSize = true;
            DayLabel.Location = new Point(534, 197);
            DayLabel.Name = "DayLabel";
            DayLabel.Size = new Size(74, 15);
            DayLabel.TabIndex = 4;
            DayLabel.Text = "Selected Day";
            // 
            // CourseCountLabel
            // 
            CourseCountLabel.AutoSize = true;
            CourseCountLabel.Location = new Point(534, 223);
            CourseCountLabel.Name = "CourseCountLabel";
            CourseCountLabel.Size = new Size(52, 15);
            CourseCountLabel.TabIndex = 5;
            CourseCountLabel.Text = "Courses:";
            // 
            // CoursesListBox
            // 
            CoursesListBox.FormattingEnabled = true;
            CoursesListBox.Location = new Point(534, 253);
            CoursesListBox.Name = "CoursesListBox";
            CoursesListBox.Size = new Size(402, 154);
            CoursesListBox.TabIndex = 6;
            // 
            // BuildingCountLabel
            // 
            BuildingCountLabel.AutoSize = true;
            BuildingCountLabel.Location = new Point(534, 428);
            BuildingCountLabel.Name = "BuildingCountLabel";
            BuildingCountLabel.Size = new Size(59, 15);
            BuildingCountLabel.TabIndex = 7;
            BuildingCountLabel.Text = "Buildings:";
            // 
            // DistanceLabel
            // 
            DistanceLabel.AutoSize = true;
            DistanceLabel.Location = new Point(534, 468);
            DistanceLabel.Name = "DistanceLabel";
            DistanceLabel.Size = new Size(55, 15);
            DistanceLabel.TabIndex = 8;
            DistanceLabel.Text = "Distance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 591);
            Controls.Add(DistanceLabel);
            Controls.Add(BuildingCountLabel);
            Controls.Add(CoursesListBox);
            Controls.Add(CourseCountLabel);
            Controls.Add(DayLabel);
            Controls.Add(DrawingPanel);
            Controls.Add(ShowRouteButton);
            Controls.Add(DayComboBox);
            Controls.Add(CRNTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox CRNTextBox;
        private ComboBox DayComboBox;
        private Button ShowRouteButton;
        private Panel DrawingPanel;
        private Label DayLabel;
        private Label CourseCountLabel;
        private ListBox CoursesListBox;
        private Label BuildingCountLabel;
        private Label DistanceLabel;
    }
}

