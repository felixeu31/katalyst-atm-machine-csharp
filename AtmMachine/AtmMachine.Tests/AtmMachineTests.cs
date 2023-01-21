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
            var moneyList = atmMachine.Withdraw(1);

            // Assert
            moneyList.Single().Value.Should().Be(1);
            moneyList.Single().Type.Should().Be(MoneyType.Coin);
        }

        [Test]
        public void withdraw_one_coin_of_two_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(2);

            // Assert
            moneyList.Single().Value.Should().Be(2);
            moneyList.Single().Type.Should().Be(MoneyType.Coin);
        }



        [Test]
        public void withdraw_one_bill_of_five_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(5);

            // Assert
            moneyList.Single().Value.Should().Be(5);
            moneyList.Single().Type.Should().Be(MoneyType.Bill);
        }


        [Test]
        public void withdraw_two_coins_of_two_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(4);

            // Assert
            moneyList.Should().HaveCount(2);
            moneyList.Should().AllSatisfy(x => x.Value.Should().Be(2));
            moneyList.Should().AllSatisfy(x => x.Type.Should().Be(MoneyType.Coin));
        }
    }
}