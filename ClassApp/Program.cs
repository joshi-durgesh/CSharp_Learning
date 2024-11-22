namespace ClassApp;

class Program
{
    static void Main(string[] args)
    {
        // Creating Instance of Car class
        Car audi = new Car("Audi", "A3");
        Car bmw = new Car("BMW", "i7");

        audi.Brand = "       ";
        Console.WriteLine("So car bran is " + audi.Brand);
    }
}
