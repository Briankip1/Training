// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if (((year % 4 == 0) && (year % 400 == 0)) || ((year % 100 != 0) && (year % 4 == 0)))
        {
            return true;
        }
        else
        {
            return false;
        }

        throw new NotImplementedException("You need to implement this function.");
    }
}
