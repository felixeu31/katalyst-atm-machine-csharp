namespace AtmMachine.Tests;

public class Money
{
    private Money(int value, MoneyType type)
    {
        Value = value;
        Type = type;
    }

    public static Money CoinOne = new Money(1, MoneyType.Coin);

    public readonly int Value;
    public readonly MoneyType Type;
}