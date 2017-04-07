using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Order
    {
        List<MenuItem> OrderList = new List<MenuItem>();

        public void AddToOrder(MenuItem menuItem)
        {
            OrderList.Add(menuItem);
        }
    }
}
