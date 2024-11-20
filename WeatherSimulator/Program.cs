namespace WeatherSimulator;

class Program
{
    static int days;
    static int[] temperature;
    static void Main(string[] args)
    {
        Console.Write("Enter the number of days: ");
        days = int.Parse(Console.ReadLine());

        temperature = new int[days];
        string[] conditions = { "Sunny", "Cloudy", "Rainy", "Cold", };
        int[] weatherConditions = new int[days];

        Random random = new Random();

        for (int i = 0; i < days; i++)
        {
            temperature[i] = random.Next(-10, 44);
            if (temperature[i] < 10)
            {
                weatherConditions[i] = 3;
                continue;
            }
            weatherConditions[i] = random.Next(conditions.Length);
        }
        // Console.WriteLine("Hello, World!");

        for (int i = 0; i < days; i++)
        {
            Console.WriteLine($"Wheather condition at day {i + 1} is {conditions[weatherConditions[i]]} with temprature of {temperature[i]}");
        }

        Console.WriteLine("Avrage temperature of the {0} days is {1} celcius.", days, CalculateAvrage(temperature));
    }

    static double CalculateAvrage(int[] temperatures)
    {
        double avrage = 0;
        foreach (int temperature in temperatures)
        {
            avrage += temperature;
        }
        return avrage / days;
    }
}
