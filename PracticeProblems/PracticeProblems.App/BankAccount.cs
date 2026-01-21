namespace PracticeProblems.App;

public class BankAccount // Represents a simple bank account with deposit and withdrawal functionality
{
    private double balance;

    public BankAccount(double initialBalance)// Initializes the bank account with an initial balance
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)// Deposits a specified amount into the bank account
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }
        balance += amount;
    }

    public void Withdraw(double amount)// Withdraws an amount 
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }
        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        balance -= amount;
    }

    public double GetBalance()// Returns the current balance
    {
        return balance;
    }
}
