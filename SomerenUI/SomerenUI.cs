using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            HideAllPanels(this);
            pnlDashboard.Show();
        }



        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlTeachers.Hide();


            // show dashboard
            pnlDashboard.Show();

        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            // HideAllPanels(this);
            pnlDashboard.Hide();
            pnlTeachers.Hide();



            // show students
            pnlStudents.Show();
            listViewStudents.Show();
            pnlStudents.BringToFront();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }
        public static void HideAllPanels(Form form)
        {
            // Iterate through all controls on the form
            foreach (Control control in form.Controls)
            {
                // Check if the control is a Panel
                if (control is Panel panel)
                {

                    panel.Visible = false;
                }
            }
        }

        private void ShowTeacherPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();


            // show teachers

            pnlTeachers.Show();
            listViewTeachers.Show();
            pnlTeachers.BringToFront();
            // listViewTeachers.Visible = true;




            try
            {
                // get and display all students
                List<Teacher> teachers = GetLecturers();

                DisplayTeachers(teachers);

            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private List<Teacher> GetLecturers()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                // Display Student Number
                ListViewItem liStudentNumber = new ListViewItem(student.StudentNumber.ToString());
                liStudentNumber.SubItems.Add(student.RoomID.ToString());
                liStudentNumber.SubItems.Add(student.StudentFirstName);
                liStudentNumber.SubItems.Add(student.StudentLastName);
                liStudentNumber.SubItems.Add(student.StudentPhone);
                liStudentNumber.SubItems.Add(student.StudentClass);

                liStudentNumber.Tag = student;
                listViewStudents.Items.Add(liStudentNumber);
            }
        }

        private void DisplayTeachers(List<Teacher> teachers)
        {
            // clear the listview before filling it

            listViewTeachers.Items.Clear();

            foreach (Teacher teacher in teachers)
            {
                ListViewItem li = new ListViewItem(teacher.FirstName);
                li.SubItems.Add(teacher.SecondName);
                li.SubItems.Add(teacher.Phone);
                li.SubItems.Add(teacher.Age.ToString());
                li.Tag = teacher;
                listViewTeachers.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ...
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeacherPanel();
        }

    }
}