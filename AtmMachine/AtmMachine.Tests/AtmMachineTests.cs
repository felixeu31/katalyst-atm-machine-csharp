namespace AtmMachine.Tests
{
    public class AtmMachineTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void withdraw_one_coin_of_one_euro()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var money = atmMachine.Withdraw(1);

            // Assert
            money.Value.Should().Be(1);
            money.Type.Should().Be("Coin");
        }


    }

    public class AtmMachine
    {
        public Money Withdraw(int amount)
        {
            return Money.CoinOne;
        }
    }

    public class Money
    {
        private Money(int value, string type)
        {
            Value = value;
            Type = type;
        }

        public static Money CoinOne = new Money(1, "Coin");

        public readonly int Value;
        public readonly string Type;
    }
}