﻿//Class: CSE 1321L
//Section: 11
//Term: Fall 2020
//Instructor: Peter Adeojo
//Name: Mariyaah Muttalib
//Lab#: 2

using System;

class Lab2A
{
    public static void Main(string[] args)
    {
        string name;
        string another_name;
        string verb;
        string adverb;

        Console.WriteLine("Enter a name: ");
        name = Console.ReadLine();

        Console.WriteLine("Enter another name: ");
        another_name = Console.ReadLine();

        Console.WriteLine("Enter a verb: ");
        verb = Console.ReadLine();

        Console.WriteLine("Enter an adverb: ");
        adverb = Console.ReadLine();

        Console.WriteLine("Once upon a time, there was a person named "
            + name + " who had a child named " + another_name
            + ". \nThis child would " + verb + " " + adverb + " while singing to strangers."
            );
    }
}