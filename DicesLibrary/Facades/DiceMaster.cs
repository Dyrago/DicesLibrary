using System.Collections.Generic;

namespace Dices.Facades
{
    public class DiceMaster
    {
        private DiceListBuilder _diceListBuilder;
        private Dice _dice;

        public DiceMaster() 
        {
            _dice = new Dice(); 
            _diceListBuilder = new DiceListBuilder();
        }

        public int Throw(DiceType diceType = DiceType.D100)
        {
            return _dice.Throw(diceType);
        }

        public void AddDice(DiceType diceType)
        {
            _diceListBuilder.AddDice(diceType);
        }

        public void AddManyDices(DiceType diceType, uint times)
        {
            _diceListBuilder.AddDiceTimes(diceType, times);
        }

        public void ReturnDiceList()
        {
            _diceListBuilder.ReturnDicesList();
        }

        public void AddDicesToList(List<Dice> dices)
        {
            _diceListBuilder.AddToList(dices);
        }
    }
}
