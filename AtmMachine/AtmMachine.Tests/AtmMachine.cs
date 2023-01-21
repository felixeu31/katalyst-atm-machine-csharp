namespace AtmMachine.Tests;

public class AtmMachine
{
    public Money Withdraw(int amount)
    {
        if (amount == 5)
        {
            return Money.BillFive;
        }

        if (amount == 2)
        {
            return Money.CoinTwo;
        }

        return Money.CoinOne;
    }
}