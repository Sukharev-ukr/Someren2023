using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using Microsoft.VisualBasic;
using SomerenDAL;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            HideAllPanels(this);
            pnlDashboard.Show();
            this.drinksToolStripMenuItem.Click += new System.EventHandler(this.drinksToolStripMenuItem_Click);
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            this.Controls.Add(pnlStudents);
            teacherService = new TeacherService();
        }

        private Teacher teacher;
        private Activity activity;
        private ActivitySupervisor activitySupervisor;
        private TeacherService teacherService;


        private void ShowDashboardPanel()
        {
            // hide all other panels
            HideAllPanels(this);
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlActivity.Hide();
            // pnlActivity.Hide(); DO NOT HAVE IT YET BUT TO BE IMPLEMENTED


            // show dashboard
            pnlDashboard.Show();

        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            // HideAllPanels(this);
            pnlDashboard.Hide();
            pnlTeachers.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlActivity.Hide();




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

        private void ShowRoomsPanel()
        {
            // hide all other panels
            // HideAllPanels(this);
            pnlDashboard.Hide();
            pnlTeachers.Hide();
            pnlStudents.Hide();
            pnlDrinks.Hide();
            pnlActivity.Hide();


            // show rooms
            pnlRooms.Show();
            listViewRooms.Show();
            pnlRooms.BringToFront();

            try
            {
                // get and display all rooms
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private void ShowDrinksPanel()
        {
            // hide all other panels

            pnlDashboard.Hide();
            pnlTeachers.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlActivity.Hide();


            // show drinks
            pnlDrinks.Show();
            listViewDrink.Show();
            pnlDrinks.BringToFront();

            try
            {
                // get and display all drinks
                List<Drinks> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
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
            pnlDrinks.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlRevenue.Hide();
            pnlActivity.Hide();



            // show teachers
            pnlTeachers.Show();
            listViewTeachers.Show();
            pnlTeachers.BringToFront();





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

        private void ShowActivityPanel()
        {
            // hide all other panels
            HideAllPanels(this);
            pnlDashboard.Hide();
            pnlDrinks.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlRevenue.Hide();
            pnlTeachers.Hide();
            pnlActivity.Hide();


            // show supervisors
            pnlActivity.Show();
            ListViewActivitySupervisors.Show();
            pnlActivity.BringToFront();


            try
            {
                // get and display all students

                List<ActivitySupervisor> activitySupervisors = new List<ActivitySupervisor>();

                DisplaySupervisors(activitySupervisors);



            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading supervisors: " + e.Message);
            }
        }

        private void pnlActivity_Paint(object sender, PaintEventArgs e)
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlTeachers.Hide();
            pnlStudents.Hide();

            // show Activity Supervisors
            pnlActivity.Show();


            UpdateActivitySupervisors();
        }

        private void ShowRevenuePanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlDrinks.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlTeachers.Hide();
            pnlActivity.Hide();


            // show rev
            pnlRevenue.Show();
            ListviewRevenue.Show();
            pnlRevenue.BringToFront();





            try
            {
                // get and display all students
                // List<Order> orders = GetOrders();

                //(teachers);

            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading revenue panel " + e.Message);
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

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        private List<Drinks> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drinks> drinks = drinkService.GetDrinks();
            return drinks;
        }

        private List<ActivitySupervisor> GetActivitiesSupervisor()
        {
            ActivityService activityService = new ActivityService();
            List<ActivitySupervisor> activitySupervisors = activityService.GetAllActivitySupervisors();
            return activitySupervisors;
        }

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetAllActivities();
            return activities;
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

        private void DisplaySupervisors(List<ActivitySupervisor> supervisors)
        {
            // clear the listview before filling it

            listViewTeachers.Items.Clear();
            ListViewActivitySupervisors.Items.Clear();

            foreach (ActivitySupervisor supervisor in supervisors)
            {
                ListViewItem li = new ListViewItem(supervisor.Teacher.FirstName);
                li.SubItems.Add(supervisor.Teacher.SecondName);
                li.Tag = supervisor;
                ListViewActivitySupervisors.Items.Add(li);
            }
        }



        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                // Display Room Number
                ListViewItem liRoomNumber = new ListViewItem(room.RoomNumber.ToString());
                liRoomNumber.SubItems.Add(room.RoomBuilding);
                liRoomNumber.SubItems.Add(room.RoomType.ToString());
                liRoomNumber.SubItems.Add(room.RoomCapacity.ToString());

                liRoomNumber.Tag = room;
                listViewRooms.Items.Add(liRoomNumber);
            }
        }

        private void DisplayDrinks(List<Drinks> drinks)
        {
            // clear the listview before filling it
            listViewDrink.Items.Clear();

            foreach (Drinks drink in drinks)
            {
                // Display drinks info
                ListViewItem liDrinksNumber = new ListViewItem(drink.DrinkID.ToString());
                liDrinksNumber.SubItems.Add(drink.DrinkName);
                liDrinksNumber.SubItems.Add(drink.DrinkVAT.ToString());
                liDrinksNumber.SubItems.Add(drink.DrinkType);
                liDrinksNumber.SubItems.Add(drink.DrinkPrice.ToString());
                liDrinksNumber.SubItems.Add(drink.DrinkStock.ToString());

                liDrinksNumber.Tag = drink;
                listViewDrink.Items.Add(liDrinksNumber);
            }
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
            ShowDrinksPanel();
        }


        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeacherPanel();
        }


        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveSelectedDrink();
        }

        private void RemoveSelectedDrink()
        {
            if (listViewDrink.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDrink.SelectedItems[0];
                listViewDrink.Items.Remove(selectedItem);
            }
        }

        private void EditSelectedDrink()
        {
            if (listViewDrink.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDrink.SelectedItems[0];

                // Get the current values of the selected item
                string currentName = selectedItem.SubItems[1].Text;
                string currentType = selectedItem.SubItems[3].Text;
                string currentPrice = selectedItem.SubItems[4].Text;
                string currentStock = selectedItem.SubItems[5].Text;

                // Display a dialog for the user to input the new values
                string newName = Interaction.InputBox("Enter new name:", "Edit Drink", currentName);
                string newType = Interaction.InputBox("Enter new type:", "Edit Drink", currentType);
                string newPrice = Interaction.InputBox("Enter new price:", "Edit Drink", currentPrice);
                string newStock = Interaction.InputBox("Enter new stock:", "Edit Drink", currentStock);

                // Update the ListView item if new values were provided
                if (!string.IsNullOrEmpty(newName))
                {
                    selectedItem.SubItems[1].Text = newName;
                }
                if (!string.IsNullOrEmpty(newType))
                {
                    selectedItem.SubItems[3].Text = newType;
                }
                if (!string.IsNullOrEmpty(newPrice))
                {
                    selectedItem.SubItems[4].Text = newPrice;
                }
                if (!string.IsNullOrEmpty(newStock))
                {
                    selectedItem.SubItems[5].Text = newStock;
                }
            }
        }

        private void OrderSelectedDrink()
        {
            if (listViewDrink.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDrink.SelectedItems[0];

                string currentName = selectedItem.SubItems[1].Text;
                string currentPrice = selectedItem.SubItems[4].Text;
                string currentStock = selectedItem.SubItems[5].Text;

                string quantity = Interaction.InputBox("Enter quantity:", "Order Drink", "1");
                string studentIdInput = Interaction.InputBox("Enter student ID:", "Order Drink", "1");

                if (int.TryParse(quantity, out int quantityInt) && quantityInt <= int.Parse(currentStock) && int.TryParse(studentIdInput, out int studentId))
                {
                    double totalPrice = quantityInt * double.Parse(currentPrice);

                    selectedItem.SubItems[5].Text = (int.Parse(currentStock) - quantityInt).ToString();

                    MessageBox.Show($"The total price is: {totalPrice.ToString()}");

                    int drinkId = int.Parse(selectedItem.SubItems[0].Text);

                    StoreOrderInDatabase(studentId, drinkId, quantityInt);
                }
                else
                {
                    MessageBox.Show("Invalid quantity or student ID.");
                }
            }
        }

        private void StoreOrderInDatabase(int studentId, int drinkId, int quantity)
        {
            OrderService orderService = new OrderService();

            orderService.StoreOrder(studentId, drinkId, quantity);
        }


        private void buttonEditDrink_Click(object sender, EventArgs e)
        {
            EditSelectedDrink();

        }

        private void buttonOrderDrink_Click(object sender, EventArgs e)
        {
            OrderSelectedDrink();
        }


        private void GenerateRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = StartPick.Value;
                DateTime endDate = EndPick.Value;

                if (startDate <= endDate && endDate <= DateTime.Now)
                {
                    GenerateRevenueReport(startDate, endDate);
                }
                else
                {
                    MessageBox.Show("The date you are trying to select is invalid. Please select a valid date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the revenue report: " + ex.Message);
            }
        }

        public void GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            OrderDao orderDao = new OrderDao();

            int numberOfDrinksSold = orderDao.GetTotalDrinksSold(startDate, endDate);
            double totalTurnover = orderDao.GetTurnover(startDate, endDate);
            int numberOfCustomers = orderDao.GetNumberOfCustomers(startDate, endDate);

            // Clear existing items in ListViewRevenue
            ListviewRevenue.Clear();


            TotalNumberOfSalesText.Text = $"Total number of sales: \n{numberOfDrinksSold}";
            TurnoverPlaneText.Text = $"Turnover: \n{totalTurnover:C}";
            NumberOfCustomersPlaneText.Text = $"Number of customers: \n{numberOfCustomers}";

        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();

        }

        private void dashboardToolStripMenuItem0_Click(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void SupervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivityPanel();
        }

        private void UpdateActivitySupervisors()
        {

            listViewTeachers.Items.Clear();
            ListViewActivitySupervisors.Items.Clear();
            listViewActivities.Items.Clear();

            foreach (Activity activity in GetActivities())
            {
                ListViewItem activityItem = new ListViewItem(activity.ActivitiyName);
                activityItem.SubItems.Add(activity.StartTime.ToString());
                activityItem.SubItems.Add(activity.FinishTime.ToString());
                activityItem.Tag = activity;
                listViewActivities.Items.Add(activityItem);

            }

            foreach (Teacher teacher in GetLecturers())
            {
                ListViewItem teacherItem = new ListViewItem(teacher.FirstName + " " + teacher.SecondName);
                teacherItem.Tag = teacher;
                listViewActivityTeachers.Items.Add(teacherItem);
            }

            foreach (ActivitySupervisor activitySupervisor in GetActivitiesSupervisor())
            {
                ListViewItem activitySupervisorItem = new ListViewItem(activitySupervisor.Activity.ActivitiyName);
                activitySupervisorItem.SubItems.Add(activitySupervisor.Teacher.FirstName + " " + activitySupervisor.Teacher.SecondName);
                activitySupervisorItem.Tag = activitySupervisor;
                ListViewActivitySupervisors.Items.Add(activitySupervisorItem);
            }


        }

        private void btnAddSupervisor_Click(object sender, EventArgs e)
        {

            ActivitySupervisor activitySupervisor = new ActivitySupervisor(this.activity.ActivityId, this.teacher.LecturerID);

            ActivityService activityService = new ActivityService();
            activityService.AddActivitySupervisor(activitySupervisor);
            UpdateActivitySupervisors();

        }

        private void ListViewActivitySupervisors_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.activitySupervisor = (ActivitySupervisor)ListViewActivitySupervisors.SelectedItems[0].Tag;
        }

        private void listViewActivityTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.teacher = (Teacher)listViewActivityTeachers.SelectedItems[0].Tag;
        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.activity = (Activity)listViewActivities.SelectedItems[0].Tag;
        }

        private void btnRemoveSupervisor_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove this supervisor?", "Remove Supervisor", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ActivityService activityService = new ActivityService();
                activityService.RemoveActivitySupervisor(this.activitySupervisor);
                UpdateActivitySupervisors();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        // Lecturers

        private void AddLecturer()
        {
            string lecturerIdInput = Interaction.InputBox("Enter lecturer ID:", "Add Lecturer");
            string firstNameInput = Interaction.InputBox("Enter first name:", "Add Lecturer");
            string secondNameInput = Interaction.InputBox("Enter second name:", "Add Lecturer");
            string phoneInput = Interaction.InputBox("Enter phone number:", "Add Lecturer");
            string ageInput = Interaction.InputBox("Enter age:", "Add Lecturer");
            string roomIdInput = Interaction.InputBox("Enter room ID:", "Add Lecturer");

            if (int.TryParse(lecturerIdInput, out int lecturerIdInt) && int.TryParse(ageInput, out int ageInt) && int.TryParse(roomIdInput, out int roomIdInt))
            {
                Teacher newTeacher = new Teacher(lecturerIdInt, firstNameInput, secondNameInput, phoneInput, ageInt);
                teacherService.AddTeacher(newTeacher, roomIdInt);
                UpdateActivitySupervisors();
            }
            else
            {
                MessageBox.Show("Invalid lecturer ID, age, or room ID.");
            }
        }

        private void RemoveSelectedLecturer()
        {
            if (listViewTeachers.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTeachers.SelectedItems[0];

                Teacher selectedTeacher = (Teacher)selectedItem.Tag;

                listViewTeachers.Items.Remove(selectedItem);

                teacherService.RemoveTeacher(selectedTeacher.LecturerID);
            }
        }



        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            AddLecturer();
        }


        private void btnChangeLecturer_Click(object sender, EventArgs e)
        {
            string lecturerIdInput = Interaction.InputBox("Enter lecturer ID:", "Add Lecturer");
            string firstNameInput = Interaction.InputBox("Enter first name:", "Add Lecturer");
            string secondNameInput = Interaction.InputBox("Enter second name:", "Add Lecturer");
            string phoneInput = Interaction.InputBox("Enter phone number:", "Add Lecturer");
            string ageInput = Interaction.InputBox("Enter age:", "Add Lecturer");
            string roomIdInput = Interaction.InputBox("Enter room ID:", "Add Lecturer");

            if (int.TryParse(lecturerIdInput, out int lecturerIdInt) && int.TryParse(ageInput, out int ageInt) && int.TryParse(roomIdInput, out int roomIdInt))
            {
                RemoveSelectedLecturer();

                Teacher newTeacher = new Teacher(lecturerIdInt, firstNameInput, secondNameInput, phoneInput, ageInt);
                teacherService.AddTeacher(newTeacher, roomIdInt);
                UpdateActivitySupervisors();
            }
            else
            {
                MessageBox.Show("Invalid lecturer ID, age, or room ID.");
            }
        }



        private void btnRemoveLecturer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove this lecturer?", "Remove Lecturer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RemoveSelectedLecturer();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

    }
}