// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        while (speed > 0)
        {
            if ((speed >= 1) && (speed <= 4))
            {
                return (100 / 100);
            }
            if ((speed >= 5) && (speed <= 8))
            {
                return (90 / 100f);
            }
            if (speed == 9)
            {
                return (80 / 100f);
            }
            if (speed == 10)
            {
                return (77 / 100f);
            }
        }
        return 0;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }

    public static double ProductionRatePerHour(int speed)
    {
        if (speed > 0)
        {
            return SuccessRate(speed) * 221 * speed;
        }
        else
        {
            return 0;
        }

        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double workingItemsPerMinute = ProductionRatePerHour(speed) / 60;
        return (int)workingItemsPerMinute;

        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}