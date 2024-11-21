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
        string[] weatherConditions = new string[days];

        Random random = new Random();

        for (int i = 0; i < days; i++)
        {
            temperature[i] = random.Next(-10, 44);
            if (temperature[i] < 10)
            {
                weatherConditions[i] = conditions[3];
                continue;
            }
            weatherConditions[i] = conditions[random.Next(conditions.Length)];
        }

        for (int i = 0; i < days; i++)
        {
            Console.WriteLine($"Wheather condition at day {i + 1} is {weatherConditions[i]} with temprature of {temperature[i]}");
        }

        Console.WriteLine("Avrage temperature of the {0} days is {1} celcius.", days, CalculateAvrage(temperature));

        //Finding min and max of the temperature
        Console.WriteLine("The min temperature in the {0} days is {1} degree celcius.", days, temperature.Min());

        Console.WriteLine("And the max temperature in the {0} days is {1} degree celcius.", days, MaxTemp(temperature));

        Console.WriteLine("The most common weather is {0}.", CommonWheather(weatherConditions));

    }

    // Calaculating the avrage of temperature on the basis of provided days
    static double CalculateAvrage(int[] temperatures)
    {
        double avrage = 0;
        foreach (int temperature in temperatures)
        {
            avrage += temperature;
        }
        return avrage / days;
    }

    // Finding the max of the temperature from the temperature array manually
    static int MaxTemp(int[] temperatures)
    {
        int max = 0;
        foreach (int temperature in temperatures)
        {
            if (max < temperature)
            {
                max = temperature;
            }
        }
        return max;
    }

    // Finding most common wheather condition
    static string CommonWheather(string[] conditions)
    {
        int count = 0;
        string mostCommon = conditions[0];

        for (int i = 0; i < conditions.Length; i++)
        {
            int tempCount = 0;
            for (int j = 0; j < conditions.Length; j++)
            {
                if (conditions[j] == conditions[i])
                {
                    tempCount++;
                }
            }
            if (tempCount > count)
            {
                count = tempCount;
                mostCommon = conditions[i];
            }
        }
        return mostCommon;
    }
}
