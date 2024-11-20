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

PrintBio("Durgesh",age,"Male");