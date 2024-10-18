namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();

        Fundament fundamental = new Fundament();
        
        fundamental.CheckOddOrEven(4);

        string interestingFact = fundamental.GetAInterestingFact("Crocodylidae is the latin name for crocodile");

        fundamental.SumTwoNumbers();

        double sumResult = fundamental.SumTwoNumbersOfGivenType(5.0, 10.0);

        fundamental.PrintFibonnaciSeries(10);

        string reversedString = fundamental.ReverseString("Pikachu");

        int n = 5;
        int factorialResult = fundamental.RecursiveFactorial(n);


    }
}
