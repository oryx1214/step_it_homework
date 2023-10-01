// public delegate void Operation(double amount);
// public class Bankacc
// {
//     private double balance;
//     private string name;
//     public Bankacc(string name, double balance)
//     {
//         this.name = name;
//         this.balance = balance;
//     }
//     public void Deposit(double amount)
//     {
//         balance += amount;
//         Console.WriteLine($"Deposited: {amount:C}. New balance: {balance:C}");
//         AccOperation(amount, "Deposit");
//     }
//     public void Withdraw(double amount)
//     {
//         if (balance >= amount)
//         {
//             balance -= amount;
//             Console.WriteLine($"Withdrawn: {amount:C}. New balance: {balance:C}");
//             AccOperation(amount, "Withdrawal");
//         }
//         else
//         {
//             Console.WriteLine("Insufficient funds. Withdrawal failed.");
//         }
//     }
//
//     public void PrintBalance()
//     {
//         Console.WriteLine($"Current balance for account '{name}': {balance:C}");
//     }
//
//     public event Operation AccOperation;
//
// }
//
// class Program
// {
//     static void Main()
//     {
//         Bankacc account = new Bankacc("Anver's account", 1000);
//
//         account.AccOperation += LogOperation;
//
//         account.Deposit(500);
//         account.Withdraw(200);
//         account.Withdraw(1000); 
//
//         account.PrintBalance();
//     }
//
//     static void LogOperation(double amount)
//     {
//         Console.WriteLine($"Logged operation. Amount: {amount:C}");
//     }
// }