using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public void InsertOrder(int studentId, int drinkId, int orderAmount)
        {
            // Get the maximum OrderID currently in the table
            string queryMaxId = "SELECT MAX(OrderID) FROM dbo.ORDERS";
            DataTable dataTable = ExecuteSelectQuery(queryMaxId, new SqlParameter[0]);
            int maxId = (dataTable.Rows[0][0] is DBNull) ? 0 : Convert.ToInt32(dataTable.Rows[0][0]);

            // Create the SQL query
            string query = "INSERT INTO dbo.ORDERS (OrderID, StudentID, DrinkID, OrderAmount, OrderDate) VALUES (@orderId, @studentId, @drinkId, @orderAmount, @OrderDate)";

            // Create the SQL parameters
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@orderId", maxId + 1),
            new SqlParameter("@studentId", studentId),
            new SqlParameter("@drinkId", drinkId),
            new SqlParameter("@orderAmount", orderAmount),
            new SqlParameter("@OrderDate", DateTime.Now)
            };

            // Call the ExecuteEditQuery method to execute the query
            ExecuteEditQuery(query, parameters);
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    Id = (int)dr["OrderID"],
                    DrinkId = (int)dr["DrinkID"],
                    StudentId = (int)dr["StudentID"],
                    amount = (int)dr["OrderAmount"]
                };

                orders.Add(order);
            }

            return orders;
        }

        /// <summary>
        /// Retrieves the total number of drinks sold within the specified date range.
        /// </summary>
        /// <param name="startDate">The start date of the period to query.</param>
        /// <param name="endDate">The end date of the period to query.</param>
        /// <returns>The total number of drinks sold within the specified date range.</returns>
        public int GetTotalDrinksSold(DateTime startDate, DateTime endDate)
        {

            // SQL query to calculate the sum of OrderAmount within the specified date range
            string query = "SELECT SUM([OrderAmount]) FROM [ORDERS] WHERE CAST([OrderDate] AS DATE) BETWEEN @StartDate AND @EndDate; ";

            // SQL parameters for the start and end date of the query range
            SqlParameter[] parameters =
            {
        new SqlParameter("@StartDate", startDate),
        new SqlParameter("@EndDate", endDate)
    };

            // Execute the SQL query and retrieve the result
            DataTable resultTable = ExecuteSelectQuery(query, parameters);
           
            // Check if there are rows returned and if the value is not DBNull
            if (resultTable.Rows.Count > 0 && resultTable.Rows[0][0] != DBNull.Value)
            {
                // Convert the result to an integer representing the total number of drinks sold
                int numberOfDrinksSold = Convert.ToInt32(resultTable.Rows[0][0]);
                return numberOfDrinksSold;
            }

            // If no rows are returned or the value is DBNull, return 0
            return 0;
        }

        /// <summary>
        /// Retrieves the total turnover (sales revenue) within the specified date range.
        /// </summary>
        /// <param name="startDate">The start date of the period to query.</param>
        /// <param name="endDate">The end date of the period to query.</param>
        /// <returns>The total turnover (sales revenue) within the specified date range.</returns>
        public double GetTurnover(DateTime startDate, DateTime endDate)
        {
            // SQL query to calculate the sum of (OrderAmount * price) within the specified date range
            string query = "SELECT SUM(ORDERS.OrderAmount * Drinks.DrinkPrice) " +
                           "FROM ORDERS " +
                           "INNER JOIN Drinks ON ORDERS.DrinkID = Drinks.DrinkID " +
                           "WHERE CAST(ORDERS.OrderDate AS DATE) BETWEEN @StartDate AND @EndDate; ";

            // SQL parameters for the start and end date of the query range
            SqlParameter[] parameters =
            {
        new SqlParameter("@StartDate", startDate),
        new SqlParameter("@EndDate", endDate)
    };

            // Execute the SQL query and retrieve the result
            DataTable resultTable = ExecuteSelectQuery(query, parameters);

            // Check if there are rows returned and if the value is not DBNull
            if (resultTable.Rows.Count > 0 && resultTable.Rows[0][0] != DBNull.Value)
            {
                // Convert the result to a double representing the total turnover
                double turnover = Convert.ToDouble(resultTable.Rows[0][0]);
                return turnover;
            }

            // If no rows are returned or the value is DBNull, return 0
            return 0;
        }


        /// <summary>
        /// Retrieves the number of unique customers who made orders within the specified date range.
        /// </summary>
        /// <param name="startDate">The start date of the period to query.</param>
        /// <param name="endDate">The end date of the period to query.</param>
        /// <returns>The number of unique customers who made orders within the specified date range.</returns>
        public int GetNumberOfCustomers(DateTime startDate, DateTime endDate)
        {
            // SQL query to count the number of distinct student IDs from orders made within the specified date range
            string query = "SELECT COUNT(DISTINCT StudentID) " +
                           "FROM [ORDERS] " +
                           "WHERE CAST([OrderDate] AS DATE) BETWEEN @startDate AND @endDate";

            // SQL parameters for the start and end date of the query range
            SqlParameter[] parameters =
            {
        new SqlParameter("@startDate", startDate),
        new SqlParameter("@endDate", endDate)
    };

            // Execute the SQL query and retrieve the result
            DataTable resultTable = ExecuteSelectQuery(query, parameters);

            // Check if there are rows returned and if the value is not DBNull
            if (resultTable.Rows.Count > 0 && resultTable.Rows[0][0] != DBNull.Value)
            {
                // Convert the result to an integer representing the number of customers
                int numberOfCustomers = Convert.ToInt32(resultTable.Rows[0][0]);
                return numberOfCustomers;
            }

            // If no rows are returned or the value is DBNull, return 0
            return 0;
        }

       

    }

}
