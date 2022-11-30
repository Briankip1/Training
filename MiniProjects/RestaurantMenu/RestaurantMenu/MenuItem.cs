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
            Print();
        } 
        
        public void Print()
        {
            Console.WriteLine($"{name}\n, {calories}\n, {price}");
        }
    }
}
