namespace AtmMachine.Tests
{
    public class AtmMachineTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void withdraw_one_coin_of_one_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var money = atmMachine.Withdraw(1);

            // Assert
            money.Value.Should().Be(1);
            money.Type.Should().Be(MoneyType.Coin);
        }

        [Test]
        public void withdraw_one_coin_of_two_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var money = atmMachine.Withdraw(2);

            // Assert
            money.Value.Should().Be(2);
            money.Type.Should().Be(MoneyType.Coin);
        }
    }
}