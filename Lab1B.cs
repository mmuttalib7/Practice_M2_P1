using System;

// Program Lab1B.cs
// Demonstrate reading a string from the user.
public class Lab1B
{
// Reads a character string from the user and prints it.
    public static void Main (string[] args)
    {
        string message;
        Console.Write("Enter a line of text:");
        message = Console.ReadLine();
        Console.WriteLine("You entered: \"" + message + "\"");

    }
}