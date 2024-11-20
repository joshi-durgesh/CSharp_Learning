namespace WeatherSimulator;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of days: ");
        int days = int.Parse(Console.ReadLine());

        int[] temprature = new int[days];
        string[] conditions = { "Sunny", "Cloudy", "Rainy", "Cold", };
        int[] weatherConditions = new int[days];

        Random random = new Random();

        for (int i = 0; i < days; i++)
        {
            temprature[i] = random.Next(-10, 44);
            if (temprature[i] < 10)
            {
                weatherConditions[i] = 3;
                continue;
            }
            weatherConditions[i] = random.Next(conditions.Length);
        }
        // Console.WriteLine("Hello, World!");

        for (int i = 0; i < days; i++)
        {
            Console.WriteLine($"Wheather condition at day {i + 1} is {conditions[weatherConditions[i]]} with temprature of {temprature[i]}");
        }
    }
}
