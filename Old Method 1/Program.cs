namespace Old_Method_1;

internal class Program
{
    // Creating Field(or Instance variable or Global variable)
    static int myResult;
    static void Main(string[] args)
    {
        // Taking inputs from user
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        myResult = Addition(num1, num2);
        Console.WriteLine("The sum of the {0} and {1} is {2}. ", num1, num2, myResult);

        // Accessing Substraction method with the help of program instance we created    
        myResult = Substraction(num1, num2);
        Console.WriteLine("The minus of the {0} and {1} is {2}. ", num1, num2, myResult);
    }


    static int Addition(int num1, int num2)
    {
        myResult = num1 + num2;
        return myResult;
    }

    static int Substraction(int num1, int num2)
    {
        myResult = num1 - num2;
        return myResult;
    }
}

// Program myProgram = new Program(); 
// we created instace of our program to use non static method inside main method