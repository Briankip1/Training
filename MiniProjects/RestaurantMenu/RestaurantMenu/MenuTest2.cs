using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class MenuTest2
    {
        public static void Test(string[] args)
        {
            Sandwich sandwich = new Sandwich("American Sub", 507, 4.99f, "seeded bread");
            Menu menu = new Menu("BurgerKing");
            menu.Add(sandwich);
            Beverage beverage = new Beverage("tea", 80, 1.99f,true);
            menu.Add(beverage);
            menu.Print();
            Console.ReadLine();
        }
    }
}
