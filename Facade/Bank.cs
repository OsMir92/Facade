using System;

namespace Facade
{
    class Bank
    {
        public bool HasSufficientSavings(Customer customer, int amount)
        {
            Console.WriteLine("Evaluando ahorros de " + customer.Name);
            return true;
        }
    }
}
