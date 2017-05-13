namespace SecondSimpleStrategy
{
    public class Account
    {
		public int Number { get; private set; }
		public double Balance { get; private set; }

		public Account(int number)
		{
			this.Number = number;
			this.Balance = 0;
		}

		public void Deposit(double value)
		{
			this.Balance += value;
		}
    }
}
