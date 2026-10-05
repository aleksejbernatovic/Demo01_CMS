using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.BusinessLayer;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }
        public Customer Customer { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public Address ShippingAddress { get; set; }
        public int OrderId { get; private set; }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
