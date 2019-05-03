using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class OrderItem
    {
        public Product product { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        public bool Validate()
        {
            return true;
        }

        public Product Retrieve()
        {
            return product;
        }

        public void Save()
        {

        }
    }
}
