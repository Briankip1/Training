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
            Items = new List<MenuItem>();
        }
        public void Add(MenuItem Item)
        {
            Items.Add(Item);
        }
        public void Print()
        {
            Console.WriteLine(RestaurantName);
            Console.WriteLine(Description);
            Console.WriteLine("Name\t\tCalories\tPrice");
            foreach(MenuItem item in Items)
            {
                var listOfItems = new StringBuilder();
                //listOfItems.AppendLine("Name\t\t\tCalories\t\tPrice"); 
                listOfItems.AppendLine($"{item.name}\t\t{item.calories}\t{item.price}");
                Console.WriteLine(listOfItems.ToString());
                item.Print();
            }
 
        }
        public float Total(List<MenuItem> order)
        {
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