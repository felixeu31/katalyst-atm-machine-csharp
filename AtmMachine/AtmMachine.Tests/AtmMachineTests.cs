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
        public void withdraw_one_bill_of_ten_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(10);

            // Assert
            moneyList.Should().HaveCount(1).And.AllSatisfy(x => x.Should().Be(Money.BillTen));
        }

        [Test]
        public void withdraw_one_bill_of_twenty_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(20);

            // Assert
            moneyList.Should().HaveCount(1).And.AllSatisfy(x => x.Should().Be(Money.BillTwenty));
        }

        [Test]
        public void withdraw_one_bill_of_fifty_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(50);

            // Assert
            moneyList.Should().HaveCount(1).And.AllSatisfy(x => x.Should().Be(Money.BillFifty));
        }

        [Test]
        public void withdraw_one_bill_of_one_hundred_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(100);

            // Assert
            moneyList.Should().HaveCount(1).And.AllSatisfy(x => x.Should().Be(Money.BillOneHundred));
        }


        [Test]
        public void withdraw_one_bill_of_two_hundred_euros()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(200);

            // Assert
            moneyList.Should().HaveCount(1).And.AllSatisfy(x => x.Should().Be(Money.BillTwoHundred));
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

        [Test]
        public void withdraw_complex_amount()
        {
            // Arrange
            AtmMachine atmMachine = new();

            // Act
            var moneyList = atmMachine.Withdraw(434);

            // Assert
            moneyList.Should().BeEquivalentTo(new List<Money>
            {
                Money.BillTwoHundred,
                Money.BillTwoHundred,
                Money.BillTwenty,
                Money.BillTen,
                Money.CoinTwo,
                Money.CoinTwo
            });
        }

        [Test]
        public void withdraw_four_hundred_when_only_one_available_two_hundred_bill()
        {
            // Arrange
            AtmMachine atmMachine = new(availableBillTwoHundred: 1);

            // Act
            var moneyList = atmMachine.Withdraw(400);

            // Assert
            moneyList.Should().BeEquivalentTo(new List<Money>
            {
                Money.BillTwoHundred,
                Money.BillOneHundred,
                Money.BillOneHundred
            });
        }
    }
}