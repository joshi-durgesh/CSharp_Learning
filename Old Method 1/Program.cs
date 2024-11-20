namespace Old_Method_1;

internal class Program
{
    static void Main(string[] args)
    {
        // Taking inputs from user
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int addition = Addition(num1, num2);
        Console.WriteLine("The sum of the {0} and {1} is {2}. ",num1,num2,addition);

        // Creating instance of program class
        Program myProgram = new Program(); 

        // Accessing Substraction with the help of program instance we created    
        int substraction = myProgram.Substraction(num1, num2);
        Console.WriteLine("The minus of the {0} and {1} is {2}. ",num1,num2,substraction);
    }

    static int Addition(int num1, int num2){
        return num1 + num2;
    }

    int Substraction(int num1, int num2){
        return num1 - num2; 
    }
}
