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
        }


        private void ShowDashboardPanel()
        {
            // hide all other panels
            HideAllPanels(this);
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlActivity.Hide();


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

        private void ShowRevenuePanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlDrinks.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlTeachers.Hide();


            // show teachers
            pnlRevenue.Show();
            ListviewRevenue.Show();
            pnlRevenue.BringToFront();





            try
            {
                // get and display all students
                List<Teacher> teachers = GetLecturers();

                DisplayTeachers(teachers);

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

            // Add new items with updated values
            //ListViewItem item = new ListViewItem("Sales");
            //item.SubItems.Add(numberOfDrinksSold.ToString());
            //ListviewRevenue.Items.Add(item);

            //item = new ListViewItem("Turnover");
            //item.SubItems.Add(totalTurnover.ToString("C"));
            //ListviewRevenue.Items.Add(item);

            //item = new ListViewItem("Number of customers");
            //item.SubItems.Add(numberOfCustomers.ToString());
            //ListviewRevenue.Items.Add(item);

            LabelSales.Text = $"Sales: \n{numberOfDrinksSold}";
            LabelTurnover.Text = $"Turnover: \n{totalTurnover:C}";
            LabelNumber.Text = $"Number of customers: \n{numberOfCustomers}";
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();

        }

        private void dashboardToolStripMenuItem0_Click(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }
    }
}