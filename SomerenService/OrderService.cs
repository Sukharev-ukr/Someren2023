using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;

namespace SomerenService
{
    public class OrderService
    {
        OrderDao orderDao;

        public OrderService()
        {
            orderDao = new OrderDao();
        }

        public void StoreOrder(int studentId, int drinkId, int orderAmount)
        {
            orderDao.InsertOrder(studentId, drinkId, orderAmount);
        }
    }
}
