using Microsoft.VisualBasic;

namespace Collections;

class Program
{
    static void Main(string[] args)
    {

        /*
                // Declaring List
                List<string> colors = new List<string>();

                // Adding values
                colors.Add("red");
                colors.Add("blue");
                colors.Add("green");
                colors.Add("red");
        // * initializing list
        List<string> colors = ["red", "green", "blue", "red"];

        PrintColor(colors);

        // Removing values from list
        // colors.Remove("red"); // it will remove first occuring value
        RemoveAll(colors, "red");

        PrintColor(colors);
        */

        // Initializing
        List<int> numbers = [8, 32, 4, 10, 2, 6, 45];

        Console.WriteLine("Unsorted list items.");
        PrintAny(numbers);

        // Sort list 
        numbers.Sort();

        Console.WriteLine("Sorted list items.");
        PrintAny(numbers);

        //Using Predicate with FindAll
        // predicate is a method that takes input and return true or false
        Predicate<int> isGreaterEqualTen = t => t >= 10;

        // Finding in list
        List<int> higherEqualTen = numbers.FindAll(isGreaterEqualTen);
        Console.WriteLine("Numbers in list greater and equal to 10.");
        PrintAny(higherEqualTen);

        // method for printing numbers in list
        void PrintAny(List<int> nums)
        {
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

    }

    /*
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

        // * Method for removing multiple 
        static void RemoveAll(List<string> colors, string color)
        {
            while (colors.Remove(color))
            {
                colors.Remove(color);
            }
        }
        */
}
