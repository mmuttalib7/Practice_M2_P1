using System;

    class Assignment2C
    {
        static void Main(string[] args)
        {
            double horizontal_pixels, vertical_pixels;
            double diagonal_length, squared_vertical, squared_horizontal;
            double calc_vert_hori, square_root;


            Console.WriteLine("Horizontal Pixels: ");
            horizontal_pixels = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vertical Pixels: ");
            vertical_pixels = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Diagonal length in inches: ");
            diagonal_length = Convert.ToDouble(Console.ReadLine());

            squared_vertical = (vertical_pixels * vertical_pixels);
            squared_horizontal = (horizontal_pixels * horizontal_pixels);

            calc_vert_hori = squared_horizontal + squared_vertical;
            square_root = Math.Sqrt(calc_vert_hori)/diagonal_length;


            Console.WriteLine("Pixels per inch: " + (int)square_root);

        }
    }

