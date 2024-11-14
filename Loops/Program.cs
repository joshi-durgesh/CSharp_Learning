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
*/

//Rocket simulation
string rocket = "\r\n       |\r\n      ---\r\n     /   \\\r\n     |.o.|\r\n     _---_\r\n    //,,,\\\\\n";

for(int count = 5; count >=0; count--){
    Console.Clear();
    Console.WriteLine("Countdown " + count);
    Console.WriteLine(rocket = "\r\n" + rocket);
    if(count==0)Console.WriteLine("Rocket Landed Sucessfuly");
    Thread.Sleep(1000);
}
