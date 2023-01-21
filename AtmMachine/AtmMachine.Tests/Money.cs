namespace AtmMachine.Tests;

public class Money : IEquatable<Money>
{
    protected Money(int value, MoneyType type)
    {
        Value = value;
        Type = type;
    }

    public static Money CoinOne = new CoinOne();
    public static Money CoinTwo = new CoinTwo();
    public static Money BillFive = new BillFive();

    public readonly int Value;
    public readonly MoneyType Type;

    public override bool Equals(object? other)
    {
        if (other == null || other.GetType() != GetType())
        {
            return false;
        }
        if (ReferenceEquals(this, other)) return true;

        return Value == ((Money)other).Value && Type == ((Money)other).Type;
    }

    public bool Equals(Money? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Value == other.Value && Type == other.Type;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Value, (int)Type);
    }
}

public class CoinOne : Money
{
    public CoinOne() : base(1, MoneyType.Coin)
    {

    }
}

public class CoinTwo : Money
{
    public CoinTwo() : base(2, MoneyType.Coin)
    {

    }
}

public class BillFive : Money
{
    public BillFive() : base(5, MoneyType.Bill)
    {

    }
}