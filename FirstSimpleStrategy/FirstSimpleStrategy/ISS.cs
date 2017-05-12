namespace FirstSimpleStrategy
{
    public class ISS : ITax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.6;
        }
    }
}
