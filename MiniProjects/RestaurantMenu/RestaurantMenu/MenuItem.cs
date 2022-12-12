using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public  class MenuItem
    {
        public string name;
        public int calories;
        public float price;

        public MenuItem(string name, int calories, float price)
        {
            this.name = name;
            this.calories = calories;
            this.price = price;
        } 
        
        public virtual void Print()
        {
            var itemList = new StringBuilder();
           itemList.AppendLine("Name\t\t Calories\t Price");
           itemList.AppendLine($"{name}\t\t{calories}\t{price}");

        }
    }
}
