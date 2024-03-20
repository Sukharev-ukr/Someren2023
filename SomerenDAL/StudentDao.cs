using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT StudentNumber, RoomID, StudentFirstName, StudentLastName, StudentPhone, StudentClass FROM dbo.STUDENT";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    StudentNumber = (int)dr["StudentNumber"],
                    RoomID = (int)dr["RoomID"],
                    StudentFirstName = dr["StudentFirstName"].ToString(),
                    StudentLastName = dr["StudentLastName"].ToString(),
                    StudentPhone = dr["StudentPhone"].ToString(),
                    StudentClass = dr["StudentClass"].ToString()
                };
                students.Add(student);
            }
            return students;
        }
    }
}