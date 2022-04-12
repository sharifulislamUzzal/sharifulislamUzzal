using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Order
    {
        public int CustomerId { get; set; }
        public List<Product> Products { get; set; }
    }
}
