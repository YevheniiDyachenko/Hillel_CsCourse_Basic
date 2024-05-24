namespace _13._1_BankAccount;

abstract class BankAccount
{
    public int AccountNumber { get; }
    public string AccountHolder { get; }
    public double Balance { get; set; }

    //  Add a constructor to the BankAccount class
    public BankAccount(string accountHolder)
    {
        AccountNumber = GenerateAccountNumber();
        AccountHolder = accountHolder;
        Balance = 0.0;
    }

    // Add abstract methods to the BankAccount class:
    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);
    public abstract void DisplayAccountInfo();


    // method to generate a unique account number for each new account
    private int GenerateAccountNumber()
    {
        Random random = new Random();
        int generateAccountNumber = random.Next(1000000, 9999999);
        return generateAccountNumber;
    }


    // method to display Withdraw Info
    public void DisplayWithdrawInfo(double amount)
    {
        Console.WriteLine($"** You are trying to withdraw {amount} UAH **");
    }
}