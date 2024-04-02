using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public abstract class CreditOffer
    {
        public string BankName { get; set; }
        public double InterestRate { get; set; }
        public int LoanTerm { get; set; }
        public double LoanAmount { get; set; }

        // Метод для розрахунку суми погашення кредиту
        public abstract double CalculateRepaymentAmount();

        // Метод для дострокового погашення кредиту
        public abstract void EarlyRepayment(double amount);

        // Метод для збільшення кредитної лінії
        public abstract void IncreaseCreditLine(double amount);

    }

}
