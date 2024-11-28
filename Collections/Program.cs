namespace Collections;

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

        Console.WriteLine("Current colors in list.");

        // Accessing values with foreach loop
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }


    }
}
