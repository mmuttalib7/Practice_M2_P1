//Class: CSE 1321L
//Section: 11
//Term: Fall 2020
//Instructor: Peter Adeojo
//Name: Mariyaah Muttalib
//Lab#: 2

using System;

class Lab2C
{
    public static void Main(string[] args)
    {
        int width, height, rectangle_area, rectangle_perimeter;

        Console.Write("Enter a width: ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Enter a height: ");
        height = Convert.ToInt32(Console.ReadLine());
        

        rectangle_area = width * height;
        Console.WriteLine("The area is " + rectangle_area);

        rectangle_perimeter = width + height;
        rectangle_perimeter = 2 * rectangle_perimeter;
        Console.WriteLine("The area is " + rectangle_perimeter);
    }
}
