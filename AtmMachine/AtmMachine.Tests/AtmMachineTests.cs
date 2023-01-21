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
            moneyList.Should().HaveCount(1).And.AllSatisfy(x => x.Should().Be(Money.CoinOne));
        }

        [Test]
        public void withdraw_one_coin_of_two_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(2);

            // Assert
            moneyList.Should().HaveCount(1).And.AllSatisfy(x => x.Should().Be(Money.CoinTwo));
        }



        [Test]
        public void withdraw_one_bill_of_five_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(5);

            // Assert
            moneyList.Should().HaveCount(1).And.AllSatisfy(x => x.Should().Be(Money.BillFive));
        }


        [Test]
        public void withdraw_two_coins_of_two_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(4);

            // Assert
            moneyList.Should().HaveCount(2).And.AllSatisfy(x => x.Should().Be(Money.CoinTwo));
        }
    }
}