// Loops

// For loop
// negative counter

/*
for (int counter = 10; counter > 0; counter--)
{
    Console.WriteLine("Negative Counter " + counter);
}
// counter

for (int counter = 0; counter <= 10; ++counter)
{
    Console.WriteLine("Counter "+ counter);
}

//Rocket simulation
string rocket = "\r\n       |\r\n      ---\r\n     /   \\\r\n     |.o.|\r\n     _---_\r\n    //,,,\\\\\n";

for(int count = 5; count >=0; count--){
    Console.Clear();
    Console.WriteLine("Countdown " + count);
    Console.WriteLine(rocket = "\r\n" + rocket);
    if(count==0)Console.WriteLine("Rocket Landed Sucessfuly");
    Thread.Sleep(1000);
}


// While loop
int counter = 0;
while(counter  < 10){
    Console.WriteLine("Counter " + counter);
    counter++;
}

// Guess the number
Random random = new Random();
int randomNum = random.Next(1,11);
Console.WriteLine("Guess the number from 1 to 10:");
int guessedNum;
bool isNum = int.TryParse(Console.ReadLine(), out guessedNum);

int count = 0;

while( guessedNum != randomNum){
    if ( guessedNum < randomNum){
        Console.WriteLine("You guessed low!");
    }else{
        Console.WriteLine("You guessed high!");
    }
    Console.WriteLine("Try again.");
    int.TryParse(Console.ReadLine(), out guessedNum);
    count++;
}

Console.WriteLine("You guessed it correct in {0} times.",count);


//Do While Loop

int count = 1;

Console.WriteLine("Count from 1 to 10");
do{
    Console.WriteLine("Count "+count);
    count++;
}while(count<=10);

//Crate a caculator to calculate avrage of the numbers

double inputNum = 0;
double totalInputCount = 0;
int avgCount = 0;

do{
    Console.WriteLine("To stop execution type -1.");
    Console.WriteLine("Or write a number:");
    double.TryParse(Console.ReadLine(),out inputNum);
    if(inputNum != -1){
    avgCount++;
    totalInputCount += inputNum;
    }
}while(inputNum != -1);

if(avgCount != 0 && totalInputCount != -1){
    double avrage = totalInputCount / avgCount;
    Console.WriteLine("Avarage of {0} is {1}.",totalInputCount,avrage);
}


//Break and Continue
//break
Console.WriteLine("Break statement.");
for (int i = 0; i < 10; i++)
{
    if(i==4) break;
    Console.WriteLine(i);
}

// continue
Console.WriteLine("\nContinue statement.");
for (int i = 0; i < 10; i++)
{
    if(i == 4) continue;
    Console.WriteLine(i);
}


// Arrays 
Console.WriteLine("Arrays");

//declare an array
int[] myIntArray = new int[5];

// assign value to the array
myIntArray[0] = 16;
myIntArray[1] = 15;
myIntArray[2] = 14;
myIntArray[3] = 13;
myIntArray[4] = 12;

Console.WriteLine(myIntArray[3]);

//declare an array and set the array value
int[] myIntArray = [16, 15, 14, 13, 12, 11];
Console.WriteLine(myIntArray[3]);

// Array for weekdays

string[] weekdays = ["Sun", "Mon","Tue","Wed","Thu","Fri","Sut"];

// using length
for( int i = 0; i < weekdays.Length; i++){
    Console.WriteLine(weekdays[i]);
}

// foreach loop
foreach(var day in weekdays){
    Console.WriteLine(day);
}

// 2d arrays
// How to declare 2d array
int[,] my2dArray = new int[2,2];

// Assign value to the array
my2dArray[0,0] = 2;
my2dArray[0,1] = 4;
my2dArray[1,0] = 6;
my2dArray[1,1] = 8;

Console.WriteLine(my2dArray[1,0]);

// Declare an 2d array and set the array value

int[,] my2dArray = {{2,3},{4,5}};
Console.WriteLine(my2dArray[0,0]);

//Initialization
string[,] my2dArray = {
    {"0,0","0,1","0,2"},
    {"1,0","1,1","1,2"},
    {"2,0","2,1","2,2"}
};

Console.WriteLine(my2dArray[2,2]);

// Declare an 3d array
int [,,] my3dArrayDeclare = new int[2,2,2];

// Assign value
my3dArrayDeclare[0,0,1] = 4;

Console.WriteLine(my3dArrayDeclare[0,0,1]);

//Initialize 3d array
string[,,] my3dArray = {
    {
        {"0,0,0","0,0,1"},
        {"0,1,0","0,1,1"}
    },
    {
        {"1,0,0","1,0,1"},
        {"1,1,0","1,1,1"}
    }
};
Console.WriteLine(my3dArray[1,1,1]);

int[] array = {1,2,3,4,5};
foreach(int value in array){
    Console.WriteLine(value);
}

*/

int[,] array = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
    
};


 for(int i =0; i < array.GetLength(0); i++){
    int total = 0;
    for(int j =0; j <array.Length/ array.GetLength(0) ; j++){
        total += array[i,j];
    }
    Console.WriteLine(total);
}



