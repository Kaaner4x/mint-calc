using System.Globalization;

namespace MintCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Console.WriteLine("=== Welcome to MintCalc Loan Calculator ===\n");

            try
            {
                Console.Write("Enter Loan Amount ($/TL): ");
                double loanAmount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Monthly Net Interest Rate (e.g., 4.25): ");
                double netInterestRate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Loan Term (Months): ");
                int term = Convert.ToInt32(Console.ReadLine());

                double monthlyInstallment = CalculateMonthlyInstallment(loanAmount, netInterestRate, term, 0.15, 0.15);

                double totalPayment = Math.Round(monthlyInstallment * term, 2);
                double totalInterestCost = Math.Round(totalPayment - loanAmount, 2);

                Console.WriteLine($"\n{new string('-', 30)}");
                Console.WriteLine($"Monthly Installment : {monthlyInstallment:N2}");
                Console.WriteLine($"Total Repayment     : {totalPayment:N2}");
                Console.WriteLine($"Total Interest + Tax: {totalInterestCost:N2}");
                Console.WriteLine($"{new string('-', 30)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: Please make sure you entered the data in the correct format. ({ex.Message})");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static double CalculateMonthlyInstallment(double loanAmount, double netInterestRate, int termMonths, double kkdfRate, double bsmvRate)
        {
            double interestDecimal = netInterestRate / 100;
            double grossInterestRate = interestDecimal * (1 + kkdfRate + bsmvRate);

            if (grossInterestRate == 0)
                return loanAmount / termMonths;

            double powerTerm = Math.Pow(1 + grossInterestRate, termMonths);
            double installment = loanAmount * (grossInterestRate * powerTerm) / (powerTerm - 1);

            return Math.Round(installment, 2);
        }
    }
}