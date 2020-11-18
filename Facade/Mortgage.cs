using System;

namespace Facade
{
    class Mortgage
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} aplica para un préstamo de {1:C}\n",
              customer.Name, amount);   //{1:C} ':C' da al int formato monetario(Currency)

            bool eligible = true;

            // Revisa si el aplicante es acreditable para el prestamo
            if (!_bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(customer))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
