namespace AtmMachine.Tests;

public class AtmMachine
{
    public List<Money> Withdraw(int amount)
    {
        List<Money> result = new List<Money>();

        if (amount == 5)
        {
            result.Add(Money.BillFive);
        }
        else if (amount == 2)
        {
            result.Add(Money.CoinTwo);
        }
        else
        {
            result.Add(Money.CoinOne);

        }

        return result;
    }
}