using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.DataModels
{
    public class Reroll
    {

        public RerollType? RerollType { get; set; }

        public int Value { get; set; } = 1;

    }
}
