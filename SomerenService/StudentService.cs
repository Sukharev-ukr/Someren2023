using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService
    {
        private StudentDao studentdb;

        public StudentService()
        {
            studentdb = new StudentDao();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = studentdb.GetAllStudents();
            return students;
        }

        public Student GetStudentById(int id)
        {
            foreach (Student student in GetStudents())
            {
                if (student.StudentNumber == id)
                {
                    return student;
                }
            }

            return null;
        }
    }
}