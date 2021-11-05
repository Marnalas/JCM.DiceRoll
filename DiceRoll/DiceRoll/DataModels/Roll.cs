using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.DataModels
{
    public class Roll
    {

        public IEnumerable<Attack> AttacksList { get; set; }

        public Save Save { get; set; } = new Save();

        public int? Margin { get; set; }

        public int ResultingWounds { get; set; }

        public int ResultingDeads { get; set; }

        public Roll()
        {
            AttacksList = new List<Attack> { new Attack() };
        }

        public void AddAttack()
        {
            AttacksList = AttacksList.Append(new Attack());
        }

    }
}
