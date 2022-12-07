// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public class Player
{
    public int RollDie()
    {
        Random random = new Random();
        int range = random.Next(1, 18);
        return range;
        throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
        Random random = new Random();
        int spellStrength = random.Next(0, 99);
        return (double)spellStrength;
        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}

