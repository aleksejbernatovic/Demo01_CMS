using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BusinessLayer
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            // Code that retrieves the defined product
            return new Product(productId);
        }

        /// <summary>
        /// Saves the defined product.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            // Code that saves the defined product
            return true;
        }
    }
}
