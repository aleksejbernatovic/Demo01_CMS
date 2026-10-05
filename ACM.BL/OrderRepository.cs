using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace CMS.BusinessLayer
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // Code that retrieves the defined order
            return new Order(orderId);
        }

        /// <summary>
        /// Saves the defined order.
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            // Code that saves the defined order
            return true;
        }
    }
}
