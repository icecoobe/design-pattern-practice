using System;

namespace DesignPattern.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example in C#
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
            Console.WriteLine("------------------------------");

            // Example in real-world
            Customer user = new Customer("Luke");
            Mortgage mortgage = new Mortgage();
            bool eligible = mortgage.IsEligible(user, 3000);
            Console.WriteLine("\n" + user.Name + " has been " + (eligible ? "Approved" : "Rejected"));
            Console.WriteLine("------------------------------");

            ShapeMaker maker = new ShapeMaker();
            maker.Draw();
            Console.WriteLine("------------------------------");
        }
    }
}
