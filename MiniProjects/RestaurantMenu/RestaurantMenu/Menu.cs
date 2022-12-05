using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Items;
        public string RestaurantName;
        public string Description;

        public Menu(string name)
        {
            RestaurantName = name;
            //Items = new List<MenuItem>();
        }
        public void Add(MenuItem Item)
        {
            Items.Add(Item);
        }
        public void Print()
        {
            Console.WriteLine($"{RestaurantName}\n {Items}\n");
        }
        public int Total(List<MenuItem> order)
        {
            Items.Sum(MenuItem order => order.Total);
        }
        public int Tip(List<MenuItem> order, int percent)
        {
            return order.Count * percent;


        }
    }
}