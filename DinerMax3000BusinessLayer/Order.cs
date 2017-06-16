using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000.Business
{
    public class Order
    {
        public List<MenuItem> OrderList = new List<MenuItem>();

        public void AddToOrder(MenuItem menuItem)
        {
            OrderList.Add(menuItem);
        }

        public double Total
        {
            get
            {
                double calculatedTotal = 0;
                foreach(MenuItem item in OrderList)
                {
                    calculatedTotal += item.Price;
                }
                return calculatedTotal;
            }
        }
    }
}
