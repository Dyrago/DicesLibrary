using Dices;

namespace DicesLibrary.Test
{
    public class DiceTest
    {
        private Dice _dice;

        public DiceTest()
        {
            _dice = new Dice();
        }

        [Theory]
        [InlineData(DiceType.D4)]
        [InlineData(DiceType.D6)]
        [InlineData(DiceType.D8)]
        [InlineData(DiceType.D10)]
        [InlineData(DiceType.D12)]
        [InlineData(DiceType.D20)]
        [InlineData(DiceType.D100)]
        public void SingleThrowShouldReturnTrue(DiceType diceType) 
        {
            var value = _dice.Throw(diceType);

            Assert.True(value > 0 && value <= 100);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(9)]
        [InlineData(82)]
        [InlineData(999)]
        [InlineData(22999)]
        public void SingleThrowCustomSideDiceShouldReturnTrue(uint maxSides)
        {
            var value = _dice.Throw(maxSides);

            Assert.True(value > 0 && value <= maxSides);
        }
    }
}
