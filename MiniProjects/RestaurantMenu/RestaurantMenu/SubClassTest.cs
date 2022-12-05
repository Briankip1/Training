using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class SubClassTest
    {
        public static void Main(string[] args)
        {
            var sandwich = new Sandwich("American sub", 509, 6.99f, "seeded bread");
            sandwich.Print();

            var Beverage = new Beverage("Mountain Dew", 190, 1.99f, true);
            Beverage.Print();
        }
        
       
    }
}
