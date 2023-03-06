using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class ItemJoins
    {
        public List<string>InnerJoin(List<MenuItem> menuItems1, List<MenuItem> menuItems2)
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

        public List<MenuItem> LeftJoin(List<MenuItem> menuItems1, List<MenuItem> menuItems2)
        {
            var combinedTable = new List<MenuItem>();

            foreach(var eachItem in menuItems1)
            {
                var resultsmenuItems2 = menuItems2.Where(itemsInTwo => itemsInTwo.name == eachItem.name);
                
                    combinedTable.AddRange(resultsmenuItems2);
                    menuItems1.DefaultIfEmpty();
            }
            return combinedTable;

        }

        public List<MenuItem> RightJoin(List<MenuItem> menuItems1, List<MenuItem> menuItems2)
        {
            var combinedTableRight = new List<MenuItem>();

            foreach (var itemTwo in menuItems2)
            {
                var resultsmenuItems1 = menuItems1.Where(itemsInOne => itemsInOne.name == itemTwo.name);
               
                combinedTableRight.AddRange(resultsmenuItems1);
                menuItems2.DefaultIfEmpty();
            }
            return combinedTableRight;

        }

        public List<MenuItem> OuterJoin(List<MenuItem> menuItems1, List<MenuItem> menuItems2)
        {
            var allTables = new List<MenuItem>();

            foreach (var itemOne in menuItems1)
            {
                var combinedData = menuItems1.FindAll(itemsInTwo => itemsInTwo.name == itemOne.name);
                
                    allTables.AddRange(combinedData);
            }
              
            return allTables;

        }


    }
}
