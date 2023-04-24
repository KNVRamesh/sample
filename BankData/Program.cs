using System;
namespace DOTNET_SAMPLE;
{
    class BankAccount
     {
         static void main(string[] args)
         {
              var account = new BankAccount("Rajini", 10000);

              Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
              account.MakeWithdrawal(500, DateTime.Now, "Rent payment");

              Console.WriteLine(account.Balance);

              account.MakeWithdrawal(50, DateTime.Now, "Game");
              Console.WriteLine(account.Balance);

              Console.WriteLine(account.GetAccountHistory());
              
              // Test that the initial balances must be positive.

                try
                 {
                    var  invalidAccount = new BankAccount("invalid", -55);
                 }
                   catch (ArgumentOutOfRangeException e)
                   {
                         Console.WriteLine("Exception caught creating account with negative balance");
                         Console.WriteLine(e.ToString());
                   }
             
         }
    }
}
	 