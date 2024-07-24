using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    /*
     . Create an Order class that has order id, item name, order date and quantity. Create a collection of
Order objects. Display the data day wise from most recently ordered to least recently ordered and
by quantity from highest to lowest.*/
    internal class order

    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }

        
    }
}
