using System;

namespace FirstSimpleStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICMS icms = new ICMS();
            ISS iss = new ISS();
            ICCC iccc = new ICCC();
            Budget orcamentoFirst = new Budget(50);
            TaxCalculator taxCalculator = new TaxCalculator();

            // First way to access value.
            Console.WriteLine(icms.Calculate(orcamentoFirst));
            Console.WriteLine(iss.Calculate(orcamentoFirst));
            Console.WriteLine(iccc.Calculate(orcamentoFirst));

            // Second way to access the value.
            taxCalculator.CalculatesTax(orcamentoFirst, icms);
            taxCalculator.CalculatesTax(orcamentoFirst, iss);
            taxCalculator.CalculatesTax(orcamentoFirst, iccc);

            Console.ReadKey();
        }
    }
}
