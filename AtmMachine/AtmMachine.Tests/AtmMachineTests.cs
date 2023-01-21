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
            money.Type.Should().Be(MoneyType.Coin);
        }
    }
}