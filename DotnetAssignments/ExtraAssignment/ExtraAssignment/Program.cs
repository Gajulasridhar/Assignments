using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the monthly payment: ");
        double monthlyPayment = Convert.ToDouble(Console.ReadLine());

        double initialBalance = 1000.0; 
        PayOffCreditCard(initialBalance, monthlyPayment);
    }

    static void PayOffCreditCard(double initialBalance, double monthlyPayment)
    {
        double balance = initialBalance;
        double totalPayments = 0;
        int month = 0;
        double interestRate = 0.015;

        while (balance > 0)
        {
            month++;
            double interest = balance * interestRate;
            balance += interest;
            balance -= monthlyPayment;
            totalPayments += monthlyPayment;

            Console.WriteLine($"Month: {month} balance: {balance:F2} total payments: {totalPayments:F2}");
        }
    }
}
