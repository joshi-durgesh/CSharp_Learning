//Decisions Making
/*
//Bool Datatype

bool isRainy = true;
bool haveUmbrella = true;

// If statement

if(isRainy){
    Console.WriteLine("It's rainy.");
}

// Logical Operators

// AND &&
// True && True -> True
// True && False -> False
// False && True -> False
// Fasle && False -> False

// OR || 
// True || True -> True
// True || False -> True
// False || True -> True
// Fasle || False -> False

// NOT !
// !True -> False
// !False -> True

if (!isRainy || haveUmbrella){
    Console.WriteLine("I'm not getting Wet.");
}

//Equality Operator
// == 
// !=

// else and else if statement

if(condition){
    statement
} else if(){
    statement
}else{
    statement
}

// switch statement
int day =3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    default:
        Console.WriteLine("Another day");
        break;
}
*/

// TryParse

Console.WriteLine("Enter a number to check whether it is Even or Odd");
int num;
bool isNum = int.TryParse(Console.ReadLine(), out num);

if(isNum){
    if(num%2 == 0){
        Console.WriteLine("The number {0} is even.",num);
    }
    else{
        Console.WriteLine("The number {0} is odd.",num);
    }
} else{
    Console.WriteLine("Please enter whole number only");
}