using System.Collections.Generic;

namespace Dices
{
    public class DiceListBuilder
    {

        private List<Dice> _dices;

        public DiceListBuilder()
        {
            _dices = new List<Dice>();
        }
        
        public DiceListBuilder AddDice(DiceType diceType = DiceType.D100)
        {
            _dices.Add(new Dice(diceType));

            return this;
        }

        public DiceListBuilder AddDiceTimes(DiceType diceType = DiceType.D100, uint times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                _dices.Add(new Dice(diceType));
            } 

            return this;
        }

        public void AddToList(List<Dice> dices)
        {
            dices.AddRange(_dices);
        }

        public List<Dice> ReturnDicesList()
        {
            var dices = new List<Dice>();

            dices.AddRange(_dices);

            _dices.Clear();

            return dices;
        }
    }
}
