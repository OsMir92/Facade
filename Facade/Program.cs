using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Mortgage mortgage = new Mortgage();
            // Evalua eligibilidad del cliente
            Customer customer = new Customer("Anna Montenegro");

            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\nPrestamo para: " + customer.Name +
                ", ha sido " + (eligible ? "Approvado" : "Rechazado"));
            
            Console.ReadKey();
        }


    }
}
