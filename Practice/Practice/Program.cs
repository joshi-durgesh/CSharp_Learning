namespace Practice;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 23;
        float num2 = 1.3f;
        double num3 = 23.3;
        char grade = 'A';
        bool isPassed = false;
        string firstName = "Durgesh";
        string lastName = "Joshi";

        Console.WriteLine($"My name is {firstName} {lastName}");
        if (isPassed)
        {
            Console.WriteLine("Passed with {grade}.");

        }
        else
        {
            Console.WriteLine("Failed and have to study again the same.");
        }
    }
}
