# MintCalc Loan Calculator 🏦

A simple yet effective C# console application that calculates loan monthly installments, total repayment, and total interest costs, taking into account tax rates like KKDF and BSMV.

## 📖 What is MintCalc?

**MintCalc** is a financial tool designed to help users quickly determine the true cost of a loan. By inputting the loan amount, net interest rate, and term length, the application calculates the gross interest rate (including standard 15% KKDF and 15% BSMV taxes) and provides a clear breakdown of the repayment plan.

## 🎯 Project Purpose

The main objective of this project is to provide an easy-to-use loan calculator in C# that accurately reflects real-world banking calculations.

When a user inputs their loan details, the application:
1. **Calculates** the gross interest rate based on the net rate and tax rates.
2. **Computes** the fixed monthly installment amount.
3. **Displays** the total repayment amount and the total interest + tax cost over the life of the loan.

## 🚀 How to Run

Follow these steps to run the application on your local machine:

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) must be installed on your system.

### Steps
1. **Clone the repository** (or download the source code):
   ```bash
   git clone https://github.com/Kaaner4x/mint-calc.git
   ```
2. **Navigate to the project directory**:
   ```bash
   cd mint-calc
   ```
3. **Run the application**:
   ```bash
   dotnet run
   ```
4. **Usage**: The console will prompt you to enter the loan amount, net interest rate, and loan term (in months). Type the values and press "Enter" to see the calculation results.

## 📄 License

This project is licensed under the [MIT License](LICENSE). See the `LICENSE` file for details.
