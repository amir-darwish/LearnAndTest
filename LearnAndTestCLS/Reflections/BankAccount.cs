using System;

public class BankAccount
{
    public string AccountNumber { get; set; } = "ACC-998877";
    private decimal Balance = 1500.50m;

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    private void ApplyPenalty(decimal penalty, string reason)
    {
        Balance -= penalty;
        Console.WriteLine($"Penalty of {penalty}$ applied for: {reason}");
    }

    public static string GetBankName()
    {
        return "Global Developer Bank";
    }
}