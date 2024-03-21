namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            studentsPictureBox = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            StudentNumberColumn = new System.Windows.Forms.ColumnHeader();
            StudentRoomID = new System.Windows.Forms.ColumnHeader();
            StudentFirstNameColumn = new System.Windows.Forms.ColumnHeader();
            StudentLastNameColumn = new System.Windows.Forms.ColumnHeader();
            StudentPhoneColumn = new System.Windows.Forms.ColumnHeader();
            StudentClassColumn = new System.Windows.Forms.ColumnHeader();
            studentsLabel = new System.Windows.Forms.Label();
            pnlTeachers = new System.Windows.Forms.Panel();
            Teacher_text = new System.Windows.Forms.Label();
            PictureForTeachers = new System.Windows.Forms.PictureBox();
            listViewTeachers = new System.Windows.Forms.ListView();
            First_Name = new System.Windows.Forms.ColumnHeader();
            Last_Name = new System.Windows.Forms.ColumnHeader();
            Phone_Number = new System.Windows.Forms.ColumnHeader();
            Age = new System.Windows.Forms.ColumnHeader();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsPictureBox).BeginInit();
            pnlTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureForTeachers).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, drinksToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1924, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            roomsToolStripMenuItem.Text = "Rooms";
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            drinksToolStripMenuItem.Text = "Drinks";
            drinksToolStripMenuItem.Click += drinksToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(17, 45);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1340, 777);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(19, 22);
            lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(313, 25);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pnlTeachers);
            pnlStudents.Controls.Add(flowLayoutPanel1);
            pnlStudents.Controls.Add(studentsPictureBox);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(studentsLabel);
            pnlStudents.Location = new System.Drawing.Point(17, 45);
            pnlStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1340, 777);
            pnlStudents.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new System.Drawing.Point(1223, 328);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(286, 167);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // studentsPictureBox
            // 
            studentsPictureBox.Image = (System.Drawing.Image)resources.GetObject("studentsPictureBox.Image");
            studentsPictureBox.Location = new System.Drawing.Point(1154, 0);
            studentsPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            studentsPictureBox.Name = "studentsPictureBox";
            studentsPictureBox.Size = new System.Drawing.Size(186, 205);
            studentsPictureBox.TabIndex = 2;
            studentsPictureBox.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { StudentNumberColumn, StudentRoomID, StudentFirstNameColumn, StudentLastNameColumn, StudentPhoneColumn, StudentClassColumn });
            listViewStudents.Location = new System.Drawing.Point(23, 70);
            listViewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(1093, 509);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // StudentNumberColumn
            // 
            StudentNumberColumn.Text = "StudentNumber";
            StudentNumberColumn.Width = 140;
            // 
            // StudentRoomID
            // 
            StudentRoomID.Text = "RoomID";
            StudentRoomID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            StudentRoomID.Width = 90;
            // 
            // StudentFirstNameColumn
            // 
            StudentFirstNameColumn.Text = "FirstName";
            StudentFirstNameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            StudentFirstNameColumn.Width = 140;
            // 
            // StudentLastNameColumn
            // 
            StudentLastNameColumn.Text = "LastName";
            StudentLastNameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            StudentLastNameColumn.Width = 140;
            // 
            // StudentPhoneColumn
            // 
            StudentPhoneColumn.Text = "Phone";
            StudentPhoneColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            StudentPhoneColumn.Width = 140;
            // 
            // StudentClassColumn
            // 
            StudentClassColumn.Text = "Class";
            StudentClassColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            StudentClassColumn.Width = 100;
            // 
            // studentsLabel
            // 
            studentsLabel.AutoSize = true;
            studentsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentsLabel.Location = new System.Drawing.Point(19, 12);
            studentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            studentsLabel.Name = "studentsLabel";
            studentsLabel.Size = new System.Drawing.Size(157, 48);
            studentsLabel.TabIndex = 0;
            studentsLabel.Text = "Students";
            // 
            // pnlTeachers
            // 
            pnlTeachers.BackColor = System.Drawing.SystemColors.Control;
            pnlTeachers.Controls.Add(Teacher_text);
            pnlTeachers.Controls.Add(PictureForTeachers);
            pnlTeachers.Controls.Add(listViewTeachers);
            pnlTeachers.Location = new System.Drawing.Point(5, 0);
            pnlTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new System.Drawing.Size(1331, 767);
            pnlTeachers.TabIndex = 2;
            // 
            // Teacher_text
            // 
            Teacher_text.AutoSize = true;
            Teacher_text.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Teacher_text.Location = new System.Drawing.Point(19, 7);
            Teacher_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Teacher_text.Name = "Teacher_text";
            Teacher_text.Size = new System.Drawing.Size(156, 48);
            Teacher_text.TabIndex = 2;
            Teacher_text.Text = "Teachers";
            // 
            // PictureForTeachers
            // 
            PictureForTeachers.Image = (System.Drawing.Image)resources.GetObject("PictureForTeachers.Image");
            PictureForTeachers.Location = new System.Drawing.Point(1146, -5);
            PictureForTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PictureForTeachers.Name = "PictureForTeachers";
            PictureForTeachers.Size = new System.Drawing.Size(186, 205);
            PictureForTeachers.TabIndex = 4;
            PictureForTeachers.TabStop = false;
            // 
            // listViewTeachers
            // 
            listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { First_Name, Last_Name, Phone_Number, Age });
            listViewTeachers.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Phone_number";
            listViewTeachers.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup1 });
            listViewTeachers.Location = new System.Drawing.Point(54, 85);
            listViewTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewTeachers.Name = "listViewTeachers";
            listViewTeachers.Size = new System.Drawing.Size(1085, 659);
            listViewTeachers.TabIndex = 1;
            listViewTeachers.UseCompatibleStateImageBehavior = false;
            listViewTeachers.View = System.Windows.Forms.View.Details;
            // 
            // First_Name
            // 
            First_Name.Text = "First_Name";
            First_Name.Width = 150;
            // 
            // Last_Name
            // 
            Last_Name.Text = "Last_Name";
            Last_Name.Width = 200;
            // 
            // Phone_Number
            // 
            Phone_Number.Text = "Phone_Number";
            Phone_Number.Width = 200;
            // 
            // Age
            // 
            Age.Text = "Age";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 1050);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentsPictureBox).EndInit();
            pnlTeachers.ResumeLayout(false);
            pnlTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureForTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox studentsPictureBox;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label studentsLabel;

        private System.Windows.Forms.ColumnHeader StudentNumber;
        private System.Windows.Forms.ColumnHeader StudentFirstName;
        private System.Windows.Forms.ColumnHeader StudentLastName;
        private System.Windows.Forms.ColumnHeader RoomID;
        private System.Windows.Forms.ColumnHeader StudentPhone;
        private System.Windows.Forms.ColumnHeader StudentClass;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.Panel panelDrinks;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.Label Teacher_text;
        private System.Windows.Forms.ColumnHeader First_Name;
        private System.Windows.Forms.ColumnHeader Last_Name;
        private System.Windows.Forms.ColumnHeader Phone_Number;
        private System.Windows.Forms.ColumnHeader Age;
        // private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox PictureForTeachers;
        private System.Windows.Forms.ColumnHeader StudentNumberColumn;
        private System.Windows.Forms.ColumnHeader StudentRoomID;
        private System.Windows.Forms.ColumnHeader StudentFirstNameColumn;
        private System.Windows.Forms.ColumnHeader StudentLastNameColumn;
        private System.Windows.Forms.ColumnHeader StudentPhoneColumn;
        private System.Windows.Forms.ColumnHeader StudentClassColumn;
    }
}