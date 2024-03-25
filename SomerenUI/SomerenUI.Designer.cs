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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem0 = new System.Windows.Forms.ToolStripMenuItem();
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
            studentsPictureSomeren = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            StudentNumberColumn = new System.Windows.Forms.ColumnHeader();
            StudentRoomID = new System.Windows.Forms.ColumnHeader();
            StudentFirstNameColumn = new System.Windows.Forms.ColumnHeader();
            StudentLastNameColumn = new System.Windows.Forms.ColumnHeader();
            StudentPhoneColumn = new System.Windows.Forms.ColumnHeader();
            StudentClassColumn = new System.Windows.Forms.ColumnHeader();
            studentsLabel = new System.Windows.Forms.Label();
            pnlTeachers = new System.Windows.Forms.Panel();
            pnlDrinks = new System.Windows.Forms.Panel();
            buttonEditDrinks = new System.Windows.Forms.Button();
            buttonRemove = new System.Windows.Forms.Button();
            labelDrinksTitle = new System.Windows.Forms.Label();
            pictureBoxSomerenDrinks = new System.Windows.Forms.PictureBox();
            listViewDrink = new System.Windows.Forms.ListView();
            columnDrinkID = new System.Windows.Forms.ColumnHeader();
            columnDrinkName = new System.Windows.Forms.ColumnHeader();
            columnDrinkVAT = new System.Windows.Forms.ColumnHeader();
            columnDrinkType = new System.Windows.Forms.ColumnHeader();
            columnDrinkPrice = new System.Windows.Forms.ColumnHeader();
            columnDrinkStock = new System.Windows.Forms.ColumnHeader();
            Teacher_text = new System.Windows.Forms.Label();
            PictureForTeachers = new System.Windows.Forms.PictureBox();
            listViewTeachers = new System.Windows.Forms.ListView();
            LecturerID = new System.Windows.Forms.ColumnHeader();
            Teacher_RoomID = new System.Windows.Forms.ColumnHeader();
            First_Name = new System.Windows.Forms.ColumnHeader();
            Last_Name = new System.Windows.Forms.ColumnHeader();
            Phone_Number = new System.Windows.Forms.ColumnHeader();
            Age = new System.Windows.Forms.ColumnHeader();
            pnlRooms = new System.Windows.Forms.Panel();
            labelTitleRooms = new System.Windows.Forms.Label();
            pictureBox20 = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            columnRoomID = new System.Windows.Forms.ColumnHeader();
            columnHeader20 = new System.Windows.Forms.ColumnHeader();
            columnHeader21 = new System.Windows.Forms.ColumnHeader();
            columnHeader22 = new System.Windows.Forms.ColumnHeader();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsPictureSomeren).BeginInit();
            pnlTeachers.SuspendLayout();
            pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSomerenDrinks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureForTeachers).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
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
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem0, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem0
            // 
            dashboardToolStripMenuItem0.Name = "dashboardToolStripMenuItem0";
            dashboardToolStripMenuItem0.Size = new System.Drawing.Size(202, 34);
            dashboardToolStripMenuItem0.Text = "Dashboard";
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
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
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
            pnlStudents.Controls.Add(flowLayoutPanel1);
            pnlStudents.Controls.Add(studentsPictureSomeren);
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
            // studentsPictureSomeren
            // 
            studentsPictureSomeren.Image = (System.Drawing.Image)resources.GetObject("studentsPictureSomeren.Image");
            studentsPictureSomeren.Location = new System.Drawing.Point(1154, 0);
            studentsPictureSomeren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            studentsPictureSomeren.Name = "studentsPictureSomeren";
            studentsPictureSomeren.Size = new System.Drawing.Size(186, 205);
            studentsPictureSomeren.TabIndex = 2;
            studentsPictureSomeren.TabStop = false;
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
            pnlTeachers.Location = new System.Drawing.Point(17, 45);
            pnlTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new System.Drawing.Size(1331, 767);
            pnlTeachers.TabIndex = 2;
            // 
            // pnlDrinks
            // 
            pnlDrinks.BackColor = System.Drawing.SystemColors.Control;
            pnlDrinks.Controls.Add(buttonEditDrinks);
            pnlDrinks.Controls.Add(buttonRemove);
            pnlDrinks.Controls.Add(labelDrinksTitle);
            pnlDrinks.Controls.Add(pictureBoxSomerenDrinks);
            pnlDrinks.Controls.Add(listViewDrink);
            pnlDrinks.Location = new System.Drawing.Point(13, 45);
            pnlDrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlDrinks.Name = "pnlDrinks";
            pnlDrinks.Size = new System.Drawing.Size(1327, 765);
            pnlDrinks.TabIndex = 6;
            // 
            // buttonEditDrinks
            // 
            buttonEditDrinks.Location = new System.Drawing.Point(1165, 224);
            buttonEditDrinks.Name = "buttonEditDrinks";
            buttonEditDrinks.Size = new System.Drawing.Size(112, 34);
            buttonEditDrinks.TabIndex = 6;
            buttonEditDrinks.Text = "Edit";
            buttonEditDrinks.UseVisualStyleBackColor = true;
            buttonEditDrinks.Click += buttonEditDrink_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new System.Drawing.Point(1165, 264);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new System.Drawing.Size(112, 34);
            buttonRemove.TabIndex = 5;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += button1_Click;
            // 
            // labelDrinksTitle
            // 
            labelDrinksTitle.AutoSize = true;
            labelDrinksTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDrinksTitle.Location = new System.Drawing.Point(19, 7);
            labelDrinksTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDrinksTitle.Name = "labelDrinksTitle";
            labelDrinksTitle.Size = new System.Drawing.Size(120, 48);
            labelDrinksTitle.TabIndex = 2;
            labelDrinksTitle.Text = "Drinks";
            // 
            // pictureBoxSomerenDrinks
            // 
            pictureBoxSomerenDrinks.Image = (System.Drawing.Image)resources.GetObject("pictureBoxSomerenDrinks.Image");
            pictureBoxSomerenDrinks.Location = new System.Drawing.Point(1146, -5);
            pictureBoxSomerenDrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBoxSomerenDrinks.Name = "pictureBoxSomerenDrinks";
            pictureBoxSomerenDrinks.Size = new System.Drawing.Size(186, 205);
            pictureBoxSomerenDrinks.TabIndex = 4;
            pictureBoxSomerenDrinks.TabStop = false;
            // 
            // listViewDrink
            // 
            listViewDrink.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnDrinkID, columnDrinkName, columnDrinkVAT, columnDrinkType, columnDrinkPrice, columnDrinkStock });
            listViewDrink.FullRowSelect = true;
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "Phone_number";
            listViewDrink.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup2 });
            listViewDrink.Location = new System.Drawing.Point(54, 85);
            listViewDrink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewDrink.Name = "listViewDrink";
            listViewDrink.Size = new System.Drawing.Size(1085, 659);
            listViewDrink.TabIndex = 1;
            listViewDrink.UseCompatibleStateImageBehavior = false;
            listViewDrink.View = System.Windows.Forms.View.Details;
            // 
            // columnDrinkID
            // 
            columnDrinkID.Text = "DrinkID";
            columnDrinkID.Width = 150;
            // 
            // columnDrinkName
            // 
            columnDrinkName.Text = "Drink_Name";
            columnDrinkName.Width = 150;
            // 
            // columnDrinkVAT
            // 
            columnDrinkVAT.Text = "Drink_VAT";
            columnDrinkVAT.Width = 200;
            // 
            // columnDrinkType
            // 
            columnDrinkType.Text = "Drink_Type";
            columnDrinkType.Width = 200;
            // 
            // columnDrinkPrice
            // 
            columnDrinkPrice.Text = "Drink_Price";
            columnDrinkPrice.Width = 150;
            // 
            // columnDrinkStock
            // 
            columnDrinkStock.Text = "Drink_Stock";
            columnDrinkStock.Width = 150;
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
            listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { LecturerID, Teacher_RoomID, First_Name, Last_Name, Phone_Number, Age });
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
            // LecturerID
            // 
            LecturerID.Text = "LecturerID";
            LecturerID.Width = 150;
            // 
            // Teacher_RoomID
            // 
            Teacher_RoomID.Text = "Teacher_RoomID";
            Teacher_RoomID.Width = 150;
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
            // pnlRooms
            // 
            pnlRooms.BackColor = System.Drawing.SystemColors.Control;
            pnlRooms.Controls.Add(labelTitleRooms);
            pnlRooms.Controls.Add(pictureBox20);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Location = new System.Drawing.Point(17, 45);
            pnlRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1331, 767);
            pnlRooms.TabIndex = 5;
            // 
            // labelTitleRooms
            // 
            labelTitleRooms.AutoSize = true;
            labelTitleRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTitleRooms.Location = new System.Drawing.Point(19, 7);
            labelTitleRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTitleRooms.Name = "labelTitleRooms";
            labelTitleRooms.Size = new System.Drawing.Size(129, 48);
            labelTitleRooms.TabIndex = 2;
            labelTitleRooms.Text = "Rooms";
            // 
            // pictureBox20
            // 
            pictureBox20.Image = (System.Drawing.Image)resources.GetObject("pictureBox20.Image");
            pictureBox20.Location = new System.Drawing.Point(1146, -5);
            pictureBox20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new System.Drawing.Size(186, 205);
            pictureBox20.TabIndex = 4;
            pictureBox20.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnRoomID, columnHeader20, columnHeader21, columnHeader22 });
            listViewRooms.FullRowSelect = true;
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "Phone_number";
            listViewRooms.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup3 });
            listViewRooms.Location = new System.Drawing.Point(54, 85);
            listViewRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(1085, 659);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // columnRoomID
            // 
            columnRoomID.Text = "Room_ID";
            columnRoomID.Width = 150;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Building";
            columnHeader20.Width = 200;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Room_Type";
            columnHeader21.Width = 200;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Room_Capacity";
            columnHeader22.Width = 200;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 1050);
            Controls.Add(pnlDrinks);
            Controls.Add(menuStrip1);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlRooms);
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
            ((System.ComponentModel.ISupportInitialize)studentsPictureSomeren).EndInit();
            pnlTeachers.ResumeLayout(false);
            pnlTeachers.PerformLayout();
            pnlDrinks.ResumeLayout(false);
            pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSomerenDrinks).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureForTeachers).EndInit();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem0;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox studentsPictureSomeren;
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
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Label labelTitleRooms;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader columnRoomID;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.Label labelDrinksTitle;
        private System.Windows.Forms.PictureBox pictureBoxSomerenDrinks;
        private System.Windows.Forms.ListView listViewDrink;
        private System.Windows.Forms.ColumnHeader columnDrinkID;
        private System.Windows.Forms.ColumnHeader columnDrinkName;
        private System.Windows.Forms.ColumnHeader columnDrinkVAT;
        private System.Windows.Forms.ColumnHeader columnDrinkType;
        private System.Windows.Forms.ColumnHeader columnDrinkPrice;
        private System.Windows.Forms.ColumnHeader columnDrinkStock;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEditDrinks;
        private System.Windows.Forms.ColumnHeader LecturerID;
        private System.Windows.Forms.ColumnHeader Teacher_RoomID;
    }
}