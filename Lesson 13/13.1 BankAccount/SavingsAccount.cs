namespace _13._1_BankAccount;

class SavingsAccount : BankAccount
{
    private double InterestRate { get; }

    public SavingsAccount(string accountHolder, double interestRate) : base(accountHolder)
    {
        InterestRate = interestRate;
    }

    public override void Deposit(double amount)
    {
        amount += (amount * InterestRate / 100);
        Balance += amount;
    }

    public override void Withdraw(double amount)
    {
        DisplayWithdrawInfo(amount);

        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine("**Money successfully withdrawn from the account**");
        }
        else
        {
            Console.WriteLine("**Not enough money!**");
        }
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine(
            $" Savings Account Number: {AccountNumber},\n Account Holder: {AccountHolder},\n Balance: {Balance} UAH,\n Interest Rate: {InterestRate}%");
        Console.WriteLine();
    }
}