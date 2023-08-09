using System;
using System.Collections.Generic;

namespace Dices
{
    public class Dice
    {
        private DiceType _type;

        public DiceType Type { get => _type;  set => _type = value;  }

        public Dice(DiceType diceType = DiceType.D100) { _type = diceType; }

        #region Public methods
        public int Throw()
        {
            Random random = new Random();

            return _type switch
            {
                DiceType.D4 => random.Next(1, 5),
                DiceType.D6 => random.Next(1, 7),
                DiceType.D8 => random.Next(1, 9),
                DiceType.D10 => random.Next(1, 11),
                DiceType.D12 => random.Next(1, 13),
                DiceType.D20 => random.Next(1, 21),
                DiceType.D100 => random.Next(1, 101),
                _ => 0,
            };
        } 

        public int Throw(uint maxSides)
        {
            Random random = new Random();

            return random.Next(1, (int)maxSides + 1);
        }

        public int Throw(int modifier)
        {
            return Throw() + modifier;
        }

        public IEnumerable<int> ThrowTimes(uint times)
        {
            for (int i = 0; i < times; i++)
            {
                yield return Throw();
            }
        }

        public IEnumerable<int> ThrowTimes(uint times, int modifier)
        {
            for (int i = 0; i < times; i++)
            {
                yield return Throw() + modifier;
            }
        }

        #endregion
    }
        
}
