using System;
namespace SecondSimpleStrategy
{
    public class Bold : Investment
    {
        private Random random;
		public Bold()
		{
			this.random = new Random();
		}

		public double Calculate(Account account)
		{
			int kick = random.Next(10);
			if (kick >= 0 && kick <= 1)
				return 0.005 * account.Balance;
			else if (kick >= 2 && kick <= 4)
				return 0.003 * account.Balance;
			else
                return 0.006 * account.Balance;
		}
    }
}
