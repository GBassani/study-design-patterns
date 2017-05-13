using System;
namespace SecondSimpleStrategy
{
    public interface Investment
    {
        double Calculate(Account account);
    }
}