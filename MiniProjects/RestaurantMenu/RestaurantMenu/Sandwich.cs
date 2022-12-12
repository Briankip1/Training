using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Sandwich : MenuItem
    {
        public string breadType;

        public Sandwich(string name, int calories, float price, string breadType):base(name, calories, price)
        {
            this.breadType = breadType;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(breadType);
        }
    }
}
