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
           // Items = new List<MenuItem>();
        }
        public void Add(MenuItem Item)
        {
            Items.Add(Item);
        }
        public void Print()
        {
            Console.WriteLine($"{RestaurantName}\n {Items}\n");
        }
        public float Total(List<MenuItem> order)
        {
            //Items.Sum(MenuItem order => order.Total);
            float totalOrderPrice = 0;
            foreach(MenuItem dish in order) 
            {
                totalOrderPrice += dish.price;
            }
            return totalOrderPrice;
        }
        public float Tip(List<MenuItem> order, int percent)
        {
            return Total(order) * percent/100;
        }
    }
}