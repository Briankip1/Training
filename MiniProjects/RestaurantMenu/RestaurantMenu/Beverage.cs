using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Beverage : MenuItem
    {
        bool iced;
        public Beverage(string name, int calories, float price,bool iced) : base(name, calories, price)
        {
            this.iced = iced;
        }
    }
}
