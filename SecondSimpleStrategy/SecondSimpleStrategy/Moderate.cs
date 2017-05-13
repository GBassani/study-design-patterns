using System;
namespace SecondSimpleStrategy
{
    public class Moderate : Investment
    {
		private Random random;
		public Moderate()
		{
			this.random = new Random();
		}

		public double Calculate(Account account)
		{
			if (random.Next(2) == 0)
				return 0.025 * account.Balance;
			else
				return 0.007 * account.Balance;
		}
    }
}
