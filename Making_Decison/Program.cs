//Decisions Making

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
