using System;

class Practice_CSharp
{
    public static void Main(string[] args)
    {
        string userInput;
        Console.WriteLine("Please enter your weight: ");
        userInput = Console.ReadLine();
        double weight = Convert.ToDouble(userInput);

        double moonWeight;
        moonWeight = weight * 0.165;
        Console.WriteLine("Your weight is: " + moonWeight + " in pounds." );
        

    }
}

