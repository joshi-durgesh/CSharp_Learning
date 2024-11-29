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
        */
        // * initializing list
        List<string> colors = ["red", "green", "blue", "red"];

        PrintColor(colors);

        // Removing values from list
        // colors.Remove("red"); // it will remove first occuring value
        RemoveAll(colors, "red");

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

    // * Method for removing multiple 
    static void RemoveAll(List<string> colors, string color)
    {
        while (colors.Remove(color))
        {
            colors.Remove(color);
        }
    }
}
