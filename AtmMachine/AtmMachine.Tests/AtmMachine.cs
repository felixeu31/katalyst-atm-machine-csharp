namespace AtmMachine.Tests;

public class AtmMachine
{
    private readonly Dictionary<Money, int> _availableMoney;

    public AtmMachine(
        int availableBillFiveHundred = int.MaxValue,
        int availableBillTwoHundred = int.MaxValue,
        int availableBillOneHundred = int.MaxValue,
        int availableBillFifty = int.MaxValue,
        int availableBillTwenty = int.MaxValue,
        int availableBillTen = int.MaxValue,
        int availableBillFive = int.MaxValue,
        int availableCoinTwo = int.MaxValue,
        int availableCoinOne = int.MaxValue
        )
    {
        _availableMoney= new Dictionary<Money, int>
        {
            { Money.BillFiveHundred, availableBillFiveHundred},
            { Money.BillTwoHundred, availableBillTwoHundred},
            { Money.BillOneHundred, availableBillOneHundred},
            { Money.BillFifty, availableBillFifty},
            { Money.BillTwenty, availableBillTwenty},
            { Money.BillTen, availableBillTen},
            { Money.BillFive, availableBillFive},
            { Money.CoinTwo, availableCoinTwo},
            { Money.CoinOne, availableCoinOne}
        };
    }

    public List<Money> Withdraw(int amount)
    {
        List<Money> result = new List<Money>();

        while (result.Sum(x => x.Value) < amount)
        {
            var remaining = amount - result.Sum(x => x.Value);

            var maxAvailableMoney = Money.MoneyTypes
                .Where(x => x.Value <= remaining)
                .Where(x => _availableMoney[x] > 0)
                .MaxBy(x => x.Value);

            if (maxAvailableMoney == null)
                break;

            _availableMoney[maxAvailableMoney] -= 1;
            result.Add(maxAvailableMoney);
        }

        return result;
    }
}