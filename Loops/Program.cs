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

*/

//Do While Loop

int count = 1;

Console.WriteLine("Count from 1 to 10");
do{
    Console.WriteLine("Count "+count);
    count++;
}while(count<=10);