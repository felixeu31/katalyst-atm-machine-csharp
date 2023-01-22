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
    public static Money BillTen = new BillTen();
    public static Money BillTwenty = new BillTwenty();
    public static Money BillFifty = new BillFifty();
    public static Money BillOneHundred = new BillOneHundred();
    public static Money BillTwoHundred = new BillTwoHundred();
    public static Money BillFiveHundred = new BillFiveHundred();
    public static List<Money> MoneyTypes = new()
    {
        CoinOne,
        CoinTwo,
        BillFive,
        BillTen,
        BillTwenty,
        BillFifty,
        BillOneHundred,
        BillTwoHundred,
        BillFiveHundred
    };

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

public class BillTen : Money
{
    public BillTen() : base(10, MoneyType.Bill)
    {

    }
}

public class BillTwenty : Money
{
    public BillTwenty() : base(20, MoneyType.Bill)
    {

    }
}

public class BillFifty : Money
{
    public BillFifty() : base(50, MoneyType.Bill)
    {

    }
}


public class BillOneHundred : Money
{
    public BillOneHundred() : base(100, MoneyType.Bill)
    {

    }
}

public class BillTwoHundred : Money
{
    public BillTwoHundred() : base(200, MoneyType.Bill)
    {

    }
}

public class BillFiveHundred : Money
{
    public BillFiveHundred() : base(500, MoneyType.Bill)
    {

    }
}