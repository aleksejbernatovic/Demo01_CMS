using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BusinessLayer
{
    public class OrderItemRepository
    {
        /// <summary>
        /// Retrieve one order item.
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the defined order item
            return new OrderItem(orderItemId);
        }

        /// <summary>
        /// Saves the defined order item.
        /// </summary>
        /// <returns></returns>
        public bool Save(OrderItem orderItem)
        {
            // Code that saves the defined order item
            return true;
        }
    }
}
