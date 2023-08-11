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


        [Fact]
        public void ReturnDicesShouldReturnTrue()
        {
            _listBuilder
                .AddDice()
                .AddDice()
                .AddDiceTimes(times: 10);

            var dices = _listBuilder.ReturnDicesList();

            Assert.True(dices != null && dices.Count() > 0);
        }
    }
}
