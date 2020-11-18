using System;
namespace Facade
{
    class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine("Evaluando prestamos de " + customer.Name);
            return true;
        }
    }
}
