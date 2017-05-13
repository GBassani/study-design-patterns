using System;
namespace SecondSimpleStrategy
{
    public class DirectorInvestments
    {
		public void Performs(Account account, Investment investment)
		{
			var result = investment.Calculate(account);
			account.Deposit(result * 0.75);

            Console.WriteLine("New balance: " + account.Balance);
		}
    }
}
