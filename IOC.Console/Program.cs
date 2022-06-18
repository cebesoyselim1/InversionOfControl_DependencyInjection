using System;


namespace IOC.console
{
    class Program
    {
        static void Main(string[] args)
        {
            BL bl = new BL(new OracleDAL());

            bl.GetProducts().ForEach((product) =>
            {
                Console.WriteLine($"{product.Id}/{product.Name}/{product.Price}/{product.Stock}");
            });

            Console.ReadLine();
        }
    }
}

// Resource : https://www.tutorialsteacher.com/ioc/

// Tightly Coupled => One class depends on another.
// Loosely Coupled => Reducing dependencies of one class to another.

// Inversion Of Control(IOC) => The reason of using IOC is aim o achive loosely coupled classes.

/*
    1. Tightly Coupled Classes
    2. Implement IOC using Factory Pattern
    3. Implement Dependency Inversion(DIP) by creating abstraction
    4. Implement Dependency Injection(DI)
    5. User Inversion Of Control Container(IOC Container)
    6. Loosely Coupled Classes
*/

// Dependency Inversion(DIP) => Make sure that high level classes is not implemented by low classes directly. Interfaces and abstract classes should be used to make them loosely classes.





