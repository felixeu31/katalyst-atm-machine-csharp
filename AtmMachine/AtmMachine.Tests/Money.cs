namespace AtmMachine.Tests;

public class Money
{
    private Money(int value, MoneyType type)
    {
        Value = value;
        Type = type;
    }

    public static Money CoinOne = new Money(1, MoneyType.Coin);
    public static Money CoinTwo = new Money(2, MoneyType.Coin);
    public static Money BillFive = new Money(5, MoneyType.Bill);

    public readonly int Value;
    public readonly MoneyType Type;
}