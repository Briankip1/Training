// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        while (balance != 0)
        {
            if (balance < 0)
            {
                return 3.213f;
            }
            if (balance < 1000)
            {
                return 0.5f;
            }
            if ((balance >= 1000) && (balance < 5000))
            {
                return 1.621f;
            }
            if (balance >= 5000)
            {
                return 2.475f;
            }
        }
        return 0.5f;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
    }

    public static decimal Interest(decimal balance)
    {
        decimal currentInterest = (balance * (decimal)InterestRate(balance)) / 100;
        return currentInterest;

        throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
        throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (targetBalance > balance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
    }
}

