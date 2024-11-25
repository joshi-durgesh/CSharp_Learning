namespace ClassApp;

class Program
{
    static void Main(string[] args)
    {
        /*
        // Creating Instance of Car class
        Car audi = new Car("Audi", "A3", false);
        Car bmw = new Car("BMW", "i7", true);


        Console.WriteLine("So car brand is " + audi.Brand);
        Console.WriteLine("So car brand is " + bmw.Brand);
        */

        Customer person1 = new Customer("john", "vakanda", "2784234129");
        Customer person2 = new Customer("doe");

        Console.WriteLine(person2.Name);
    }
}
