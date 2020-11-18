using System;

namespace Facade
{
    class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine("Evaluando credíto de " + customer.Name);
            return true;
        }
    }
}
