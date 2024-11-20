// Function / Methods
// Methods are structured like this
// Modifier returnType MethodName (Parameter){
// Code Block
//}

// simple method 
void PrintHello(){
    Console.WriteLine("Hello World!");
}

// PrintHello();

// Simple void method with parameter
void PrintBio(string name,int age, string gender){
    Console.WriteLine($"Hello, my name is {name} and i am {age} year's old {gender}");
}

int age = 24;

// PrintBio("Durgesh",age,"Male");

// Method that return something

int AdditionCalculator(int num1, int num2){
    int result = num1 + num2;
    return result;
}
Console.WriteLine("Enter 1st number:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 2nd number:");
int num2 = int.Parse(Console.ReadLine());

int sum =AdditionCalculator( num1, num2);
Console.Write("The sum of the {0} and {1} is :",num1,num2);
Console.WriteLine(sum);