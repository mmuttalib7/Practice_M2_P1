using System;

    class Assignment2B
    {
        static void Main(string[] args)
        {
            int width, length, square_feet_per_dot;
            int calculated_square_feet;
            double dots_per_square_foot;

            Console.WriteLine("Width: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Length: ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Square feet per dot: ");
            square_feet_per_dot = Convert.ToInt32(Console.ReadLine());

            calculated_square_feet = width * length;
            dots_per_square_foot = (calculated_square_feet);
    
            dots_per_square_foot = dots_per_square_foot / square_feet_per_dot;

            Console.WriteLine("A yard of " + calculated_square_feet + " square feet will take "
            + dots_per_square_foot + " to cut.");

        }
    }

