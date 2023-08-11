using Dices;

namespace DicesLibrary.Test
{
    public class BuildersTest
    {
        private DiceListBuilder _listBuilder;

        public BuildersTest()
        {
            _listBuilder = new DiceListBuilder();
        }

        [Fact]
        public void CreateListShouldReturnTrue()
        {
            _listBuilder
                .AddDice()
                .AddDice()
                .AddDice();

            Assert.True(_listBuilder.Dices.Count > 0);
        }
    }
}
