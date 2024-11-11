// To make a TODO list
/*
Console.WriteLine("Hello!");

// Reference Type
string myName = "Durgesh";

// Defining or setting up variable
string petName;

// Initialize Variable
petName = "Doggy";

System.Console.WriteLine($"Pet name is {petName}");

// Re-Initialize Variable
petName = "Doggy2";

Console.WriteLine($"My secong pet name is {petName}");  

*/

// Defining Variable for 2 numbers
int numFirst;
int numSecond;

// Taking input number from user
Console.WriteLine("Enter First Number:");
string inputNumFirst = Console.ReadLine();
Console.WriteLine("Enter Second Number");
string inputNumSecond = Console.ReadLine();

// Initializing two input numbers and parse it to int
numFirst = int.Parse(inputNumFirst);
numSecond = int.Parse(inputNumSecond);

Console.WriteLine($"The sum of {numFirst} and {numSecond} is {numFirst + numSecond}");