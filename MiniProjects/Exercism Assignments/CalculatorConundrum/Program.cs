// See https://aka.ms/new-console-template for more information
using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        try
        {
            switch (operation)
            {
                case "+":
                    return $"{operand1} + {operand2} = {operand1 + operand2}";

                case "*":
                    return $"{operand1} * {operand2} = {operand1 * operand2}";

                case "/":
                    return $"{operand1} / {operand2} = {operand1 / operand2}";

                case null:
                    throw new ArgumentNullException();

                case "":
                    throw new ArgumentException();

                default:
                    throw new ArgumentOutOfRangeException();
            };
        }
        catch (DivideByZeroException)
        {
            return "Division by zero is not allowed.";
        }

        throw new NotImplementedException("Please implement the SimpleCalculator.Calculate() method");
    }
}
