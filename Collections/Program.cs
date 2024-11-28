﻿namespace Collections;

class Program
{
    static void Main(string[] args)
    {

        // Declaring List
        List<string> colors = new List<string>();

        // Adding values
        colors.Add("red");
        colors.Add("blue");
        colors.Add("green");
        colors.Add("red");

        PrintColor(colors);

        // Removing values from list
        colors.Remove("red"); // it will remove first occuring value

        PrintColor(colors);


    }

    // * Method for printing color
    static void PrintColor(List<string> colors)
    {
        Console.WriteLine("Current colors in list.");

        // Accessing values with foreach loop
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
    }
}
