namespace _13._1_BankAccount;

class CheckingAccount : BankAccount
{
    private double OverdraftLimit { get; }

    public CheckingAccount(string accountHolder, double overdraftLimit) : base(accountHolder)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override void Deposit(double amount)
    {
        Balance += amount;
    }

    public override void Withdraw(double amount)
    {
        DisplayWithdrawInfo(amount);

        if (amount > Balance + OverdraftLimit)
        {
            Console.WriteLine("**Overdraft limit exceeded**");
        }
        else
        {
            Balance -= amount;
            if (Balance < 0)
            {
                Console.WriteLine("**Attention: You are using the overdraft limit.**");
            }

            Console.WriteLine("**Money successfully withdrawn from the account**");
        }
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine(
            $" Checking Account Number: {AccountNumber},\n Account Holder: {AccountHolder},\n Balance: {Balance} UAH, \n Overdraft Limit: {OverdraftLimit} UAH");
        Console.WriteLine();
    }
}