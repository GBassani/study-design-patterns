using System;

namespace SecondSimpleStrategy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Account account = new Account(125);
			Investment investment = new Bold();

            account.Deposit(250);
			Console.WriteLine(account.Balance);
            new DirectorInvestments().Performs(account, investment);

			Console.ReadKey();
        }
    }
}
