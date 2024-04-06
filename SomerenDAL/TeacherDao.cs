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
                Teacher teacher = new Teacher(
                    (int)dr["LecturerID"],
                    dr["LecturerFirstName"].ToString(),
                    dr["LecturerLastName"].ToString(),
                    dr["LecturerPhone"].ToString(),
                    (int)dr["LecturerAge"]
                );
                teachers.Add(teacher);
            }
            return teachers;
        }

        public void AddTeacher(Teacher teacher, int roomId)
        {
            string query = "INSERT INTO LECTURER (LecturerID, LecturerFirstName, LecturerLastName, LecturerPhone, LecturerAge, RoomID) VALUES (@LecturerID, @FirstName, @SecondName, @Phone, @Age, @RoomID)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@LecturerID", teacher.LecturerID);
            sqlParameters[1] = new SqlParameter("@FirstName", teacher.FirstName);
            sqlParameters[2] = new SqlParameter("@SecondName", teacher.SecondName);
            sqlParameters[3] = new SqlParameter("@Phone", teacher.Phone);
            sqlParameters[4] = new SqlParameter("@Age", teacher.Age);
            sqlParameters[5] = new SqlParameter("@RoomID", roomId);
            ExecuteEditQuery(query, sqlParameters);
        }

        //public void UpdateTeacher(Teacher teacher)
        //{
        //    string query = "UPDATE LECTURER SET LecturerFirstName = @FirstName, LecturerLastName = @SecondName, LecturerPhone = @Phone, LecturerAge = @Age WHERE LecturerID = @LecturerID";
        //    SqlParameter[] sqlParameters = new SqlParameter[5];
        //    sqlParameters[0] = new SqlParameter("@FirstName", teacher.FirstName);
        //    sqlParameters[1] = new SqlParameter("@SecondName", teacher.SecondName);
        //    sqlParameters[2] = new SqlParameter("@Phone", teacher.Phone);
        //    sqlParameters[3] = new SqlParameter("@Age", teacher.Age);
        //    sqlParameters[4] = new SqlParameter("@LecturerID", teacher.LecturerID);
        //    ExecuteEditQuery(query, sqlParameters);
        //}

        public void RemoveTeacher(int id)
        {
            string query = "DELETE FROM LECTURER WHERE LecturerID = @LecturerID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@LecturerID", id);
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}