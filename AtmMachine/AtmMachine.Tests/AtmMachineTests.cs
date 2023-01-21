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
            return new Money
            {
                Value = 1,
                Type = "Coin"
            };
        }
    }

    public class Money
    {
        public int Value { get; set; }
        public string Type { get; set; }
    }
}