﻿// To make a TODO list
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


// Simple Addition using Int
// Defining Variable for 2 numbers
int numFirst;
int numSecond;

// Taking input number from user
Console.WriteLine("Enter First Whole Number:");
string inputNumFirst = Console.ReadLine();
Console.WriteLine("Enter Second Whole Number");
string inputNumSecond = Console.ReadLine();

// Initializing two input numbers and parse it to int
numFirst = int.Parse(inputNumFirst);
numSecond = int.Parse(inputNumSecond);

// adding both numbers
int sum = numFirst + numSecond;

//String Concatnation
Console.WriteLine("The sum of "+ numFirst + " and " + numSecond " is " + sum);

// String Interpolation
Console.WriteLine($"The sum of {numFirst} and {numSecond} is {sum}"); 

*/


// Simple sum calculator using double
double firstNum;
double secondNum;

Console.WriteLine("Enter the first number:");
firstNum = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
secondNum =double.Parse(Console.ReadLine());

double sum = firstNum + secondNum;
// Rounding number to 2 decimal points
sum = Math.Round(sum, 2);

Console.WriteLine($"The sum of {firstNum} and {secondNum} is {sum}");
