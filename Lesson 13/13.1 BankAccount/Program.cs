namespace _13._1_BankAccount;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        
        // Create a savings Account
        BankAccount savingsAccount = new SavingsAccount("Іван Петренко", 5.0);
        savingsAccount.Deposit(1000);
        savingsAccount.Withdraw(500);
        savingsAccount.DisplayAccountInfo();
        
        BankAccount savingsAccount2 = new SavingsAccount("Микола Владчук", 10.0);
        savingsAccount2.Deposit(1000);
        savingsAccount2.Withdraw(20000);
        savingsAccount2.DisplayAccountInfo();

        // Create a checking Account
        BankAccount checkingAccount = new CheckingAccount("Петро Сидоренко", 500);
        checkingAccount.Deposit(2000);
        checkingAccount.Withdraw(3000);
        checkingAccount.DisplayAccountInfo();
        
        BankAccount checkingAccount2 = new CheckingAccount("Степан Лисенко", 500);
        checkingAccount2.Deposit(5000);
        checkingAccount2.Withdraw(3000);
        checkingAccount2.DisplayAccountInfo();
        
        BankAccount checkingAccount3 = new CheckingAccount("Степан Лисенко", 2000);
        checkingAccount3.Deposit(4000);
        checkingAccount3.Withdraw(5000);
        checkingAccount3.DisplayAccountInfo();
    }
}