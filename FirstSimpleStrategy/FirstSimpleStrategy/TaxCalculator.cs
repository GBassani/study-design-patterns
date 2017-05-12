using System;

namespace FirstSimpleStrategy
{
    public class TaxCalculator
    {
        public void CalculatesTax(Budget budget, ITax tax)
        {
            Console.WriteLine(tax.Calculate(budget));
        }
    }
}
