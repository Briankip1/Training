// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake)
        {
            return false;
        }
        else
        {
            return true;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake == true || prisonerIsAwake == true || archerIsAwake == true)
        {
            return true;
        }
        else
        {
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (prisonerIsAwake == true && archerIsAwake != true)
        {
            return true;
        }
        else
        {
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (((petDogIsPresent == true) && archerIsAwake != true) || (petDogIsPresent != true && prisonerIsAwake == true && knightIsAwake != true && archerIsAwake != true))
        {
            return true;
        }
        else
        {
            return false;

        }

        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}

