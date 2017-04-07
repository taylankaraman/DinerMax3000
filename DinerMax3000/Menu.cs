using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class Menu
    {
        public Menu() {
            items = new List<MenuItem>();
        }

        public string Name;
        public List<MenuItem> items;

        public void AddMenuItem(String title, string description, double price)
        {
            MenuItem newItem = new MenuItem();
            newItem.Title = title;
            newItem.Description = description;
            newItem.Price = price;
            items.Add(newItem);
        }
    }
}
