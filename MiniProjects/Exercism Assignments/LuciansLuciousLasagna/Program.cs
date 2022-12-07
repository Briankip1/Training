// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Lasagna
{
    public int minutes = 40;

    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return minutes;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        int remainingMinutes = minutes - actualMinutesInOven;
        return remainingMinutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numofLayers)
    {
        int totalPreparationTime = numofLayers * 2;
        return totalPreparationTime;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int addedLayers, int timeInOven)
    {
        return (addedLayers * 2) + timeInOven;
    }

    public static void Main(string[] args)
    {
        var lasagna = new Lasagna();
        Console.WriteLine(lasagna.ExpectedMinutesInOven());
        Console.WriteLine(lasagna.RemainingMinutesInOven(30));
        Console.WriteLine(lasagna.PreparationTimeInMinutes(2));
        Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));
    }
}

