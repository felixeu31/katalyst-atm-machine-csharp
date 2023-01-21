namespace AtmMachine.Tests;

public class AtmMachine
{
    public List<Money> Withdraw(int amount)
    {
        List<Money> result = new List<Money>();

        if (amount == 200)
        {
            result.Add(Money.BillTwoHundred);
        }
        else if (amount == 100)
        {
            result.Add(Money.BillOneHundred);
        }
        else if (amount == 50)
        {
            result.Add(Money.BillFifty);
        }
        else if (amount == 20)
        {
            result.Add(Money.BillTwenty);
        }
        else if (amount == 10)
        {
            result.Add(Money.BillTen);
        }
        else if (amount == 5)
        {
            result.Add(Money.BillFive);
        }
        else if (amount == 4)
        {
            result.Add(Money.CoinTwo);
            result.Add(Money.CoinTwo);

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