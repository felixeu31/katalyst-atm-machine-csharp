namespace AtmMachine.Tests;

public class AtmMachine
{
    public List<Money> Withdraw(int amount)
    {
        List<Money> result = new List<Money>();

        while (result.Sum(x => x.Value) < amount)
        {
            var remaining = amount - result.Sum(x => x.Value);

            var maxMoney = Money.MoneyTypes.Where(x => x.Value <= remaining).MaxBy(x => x.Value);

            if (maxMoney == null)
                break;

            result.Add(maxMoney);
        }

        return result;
    }
}