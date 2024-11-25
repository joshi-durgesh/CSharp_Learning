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

        Customer person1 = new Customer("john", "vakanda", "2784234129");
        Customer person2 = new Customer("doe");
        Customer person3 = new Customer();

        Console.WriteLine(person2.Name);
        Console.WriteLine(person3.Name);
        person3.Name = "Durgesh";
        Console.WriteLine(person3.Name);
        */

        Car myAudi = new Car("Audi", "S8", false);
        Car myBmw = new Car("BMW", "Q8", true);

        myBmw.Drive();
        myAudi.Drive();
    }
}
