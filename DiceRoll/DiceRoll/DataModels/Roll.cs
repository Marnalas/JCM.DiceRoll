using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.DataModels
{
    public class Roll
    {

        public IEnumerable<Attacker> AttackersList { get; set; }
        public IEnumerable<Defender> DefendersList { get; set; }

        public int? Margin { get; set; }

        public Roll()
        {
            AttackersList = new List<Attacker> { new Attacker { Order = 1 } };
            DefendersList = new List<Defender> { new Defender { Order = 1 } };
        }

        public void AddAttacker()
        {
            AttackersList = AttackersList.Append(new Attacker { Order = AttackersList.Count() + 1 });
        }

        public void AddDefender()
        {
            DefendersList = DefendersList.Append(new Defender { Order = DefendersList.Count() + 1 });
        }

    }
}
