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
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            // ...

            // show dashboard
            pnlDashboard.Show();

        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            panelDrinks.Hide();

            // show students
            pnlStudents.Show();

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

        private void ShowTeacherPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

            // show teachers
            // pnlTeacher.Show();

            try
            {
                // get and display all students
                List<Teacher> teachers = GetLecturers();
                // DisplayStudents(teachers);
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
            List<Teacher> teachers = GetLecturers();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ...
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}