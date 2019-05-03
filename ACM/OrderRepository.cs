using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class OrderRepository
    {

        public Order Retrieve(int orderId)
        {
            //Create the instance of the Order class
            //Pass in the requested Id
            Order order = new Order(orderId);

            //Code that retrieves the defined order
            //a populated order
            if(orderId == 10)
            {
                //Use currrent year in hard-coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0));
            }

            return order;
        }

        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool Save(Order order)
        {
            //Code that saves the pased in order

            return true;
        }
    }
}
