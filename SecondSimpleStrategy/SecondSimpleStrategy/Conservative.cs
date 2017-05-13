namespace SecondSimpleStrategy
{
    public class Conservative : Investment
    {
		public double Calculate(Account account)
		{
			return 0.008 * account.Balance;
		}
    }
}
