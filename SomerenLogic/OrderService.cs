using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class OrderService
    {
        OrderDao OrderDao;
        public OrderService()
        {
            OrderDao = new OrderDao();
        }
        public void makeOrder(Order order)
        {
            OrderDao.MakeOrder(order);
        }
        public void SendOrder(List<Order> orders)
        {

            OrderService orderService = new OrderService();

            foreach (Order orderItem in orders)
            {

                makeOrder(orderItem);

            }


        }

        public void validateOrder(List<Order> orders)
        {
            if (orders.Count >0) {
                foreach (Order o in orders)
                {
                    if (o.CustomerId <= 0)
                    {
                        throw new Exception("geen customer geselecteerd");

                    }

                }
            }
            else
            {
                throw new Exception("geen drink geselecteerd");
            }
        }



    }
}
