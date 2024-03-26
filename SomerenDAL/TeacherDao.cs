using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllLecturers()
        {
            string query = "SELECT LecturerID, RoomID, LecturerFirstName, LecturerLastName, LecturerPhone, LecturerAge FROM LECTURER ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    FirstName = dr["LecturerFirstName"].ToString(),
                    SecondName = dr["LecturerLastName"].ToString(),
                    Phone = dr["LecturerPhone"].ToString(),
                    Age = (int)dr["LecturerAge"]
                    
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}