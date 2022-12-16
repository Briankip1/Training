using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuTest
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu("BurgerKing");
            menu.Description = "The Best in town\n";
            MenuItem item3 = new MenuItem("Creamy Garlic Chicken Breast", 465, 8.99f);
            menu.Add(item3);
            MenuItem item4 = new MenuItem("Large Burger", 516, 7.98f);
            menu.Add(item4);
            //menu.Total();
            menu.Print();
            item4.calories = 500;
            menu.Print();
            Menu menu1 = new Menu("Original Pancake");
            menu1.Description = "Leading since 1985\n";
            MenuItem item5 = new MenuItem("American Style Pancake\t", 303, 3.59f);
            menu1.Add(item5);
            menu1.Print();

            List<MenuItem> order = new List<MenuItem>();
            order.Add(menu.Items[0]);
            Console.WriteLine(menu.Total(order));
            Console.ReadLine();
        }
    }
}
