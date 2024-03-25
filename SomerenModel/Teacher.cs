namespace SomerenModel
{
    public class Teacher
    {
        public int LecturerID { get; set; }     // database id
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Number { get; set; } // LecturerNumber, e.g. 47198
        public int Age { get; set; }
        public string Phone { get; set; }
    }
}