using System.Diagnostics;

public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} is Even!");
        }
        else
        {
            Console.WriteLine($"{a} is Odd.");
        }
    }

    public string GetAInterestingFact(string fact)
    {
        return "Crocodylidae is the latin name of crocodile";
    }

    public void SumTwoNumbers()
    {
        double x = 17.525;
        double y = 25.15;
        double sum = x + y;
        Console.WriteLine($"The sum of x + y is {sum}!");
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        return a + b;
    }


    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        // TODO: Implement the Fibonacci sequence
        int a = 0;
        int b = 1;
        int c;

        /* 
        c = a + b
        a = b
        b = c
        */
    }

    public string ReverseString(string str)
    {
        // TODO: reverse the given string
        return "";
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        return n;
    }


}
