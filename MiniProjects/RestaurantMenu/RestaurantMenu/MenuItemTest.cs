//See https://aka.ms/new-console-template for more information
using RestaurantMenu;

public class MenuItemTest
{
    public static void Test(string[] args)
    {
        MenuItem item1 = new MenuItem("Hamburger", 205, 5.99f);
        item1.Print();

        MenuItem item2 = new MenuItem("Egg Salad", 189, 3.69f);
        item2.Print();
    }
    
}


