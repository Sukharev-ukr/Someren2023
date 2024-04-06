namespace SomerenModel
{
    public class Teacher
    {
        public int LecturerID { get; set; }
        public string FirstName { get; set; }

        public string SecondName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }


        public Teacher(int lecturerID, string firstName, string secondName, string phone, int age)
        {
            LecturerID = lecturerID;
            FirstName = firstName;
            SecondName = secondName;
            Phone = phone;
            Age = age;
        }
    }
}