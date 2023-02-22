using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    internal class ItemJoins
    {
        public List<string> InnerJoin(List<MenuItem> menuItems1, List<MenuItem> menuItems2)
        {
            var commonNames = new List<string>();

            foreach (var item in menuItems1)
            {
               var filteredMenuItems2 =  menuItems2.Where(item2 => item2.name == item.name);
                if(filteredMenuItems2.Any())
                {
                    commonNames.Add(item.name);
                }
            }

            return commonNames;

        } 
    }
}
