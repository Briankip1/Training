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
            MenuItem item3 = new MenuItem("pizza", 465, 8.99f);
            Menu menu1 = new Menu("Original Pancake");
            MenuItem item4 = new MenuItem("American Style Pancake", 303, 3.59f);
            Console.WriteLine(menu.Add(item3));
            Console.WriteLine(menu1.Add(item4));
            Console.ReadLine();
        }
    }
}
