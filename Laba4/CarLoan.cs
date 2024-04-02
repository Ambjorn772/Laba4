using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class CarLoan : CreditOffer
    {
        

        public override double CalculateRepaymentAmount()
        {
            return LoanAmount * (1 + InterestRate);
        }

        public override void EarlyRepayment(double amount)
        {
            Console.WriteLine($"Early repayment of ${amount} for car loan at {BankName}");
            // Віднімаємо погашену суму від загального кредиту
            LoanAmount -= amount;
        }

        public override void IncreaseCreditLine(double amount)
        {
            LoanAmount += amount;
            Console.WriteLine($"Increasing credit line by ${amount} for car loan at {BankName}");
        }

    }
}
