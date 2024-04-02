using System;

using Laba4;
class Program
{
    static void Main(string[] args)
    {
        Flower rose = new Flower("red", "green", false);

        Console.WriteLine("Before blossoming:");
        Console.WriteLine(rose);

        rose.Blossom();
        rose.PrintBudColor();



        //--------------------------------------------------
        


        var carLoanOffer = new CarLoan
        {
            BankName = "Bank A",
            InterestRate = 0.08,
            LoanTerm = 5,
            LoanAmount = 10000
        };

        var mortgageLoanOffer = new MortgageLoan
        {
            BankName = "Bank B",
            InterestRate = 0.05,
            LoanTerm = 10,
            LoanAmount = 200000
        };

        
        var client = new Client("John");
        client.CreditOffers.Add(carLoanOffer);
        client.CreditOffers.Add(mortgageLoanOffer);

        
        Console.WriteLine("Choose a credit offer:");
        Console.WriteLine("1. Car Loan");
        Console.WriteLine("2. Mortgage Loan");

        int choice = int.Parse(Console.ReadLine());
        CreditOffer selectedOffer = null;

        switch (choice)
        {
            case 1:
                selectedOffer = client.FindCreditOffer("Bank A", typeof(CarLoan));
                break;
            case 2:
                selectedOffer = client.FindCreditOffer("Bank B", typeof(MortgageLoan));
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        if (selectedOffer != null)
        {
            Console.WriteLine($"Bank: {selectedOffer.BankName}");
            Console.WriteLine($"Interest Rate: {selectedOffer.InterestRate}");
            Console.WriteLine($"Loan Term: {selectedOffer.LoanTerm}");
            Console.WriteLine($"Repayment Amount: {selectedOffer.CalculateRepaymentAmount()}");

           
            Console.WriteLine("Do you want to make early repayment or increase credit line? (R/I/N)");
            string response = Console.ReadLine();
            if (response.ToUpper() == "R")
            {
                Console.WriteLine("Enter early repayment amount:");
                double amount = double.Parse(Console.ReadLine());
                selectedOffer.EarlyRepayment(amount);
                Console.WriteLine($"Updated Loan Amount: {selectedOffer.LoanAmount}");
            }
            else if (response.ToUpper() == "I")
            {
                Console.WriteLine("Enter amount to increase credit line:");
                double amount = double.Parse(Console.ReadLine());
                selectedOffer.IncreaseCreditLine(amount);
                Console.WriteLine($"Updated Loan Amount: {selectedOffer.LoanAmount}");
            }
        }

        Console.ReadLine();
    }
}
    