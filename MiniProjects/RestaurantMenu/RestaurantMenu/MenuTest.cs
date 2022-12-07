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
            menu.Add(MenuItem.item1);
        }
    }
}
