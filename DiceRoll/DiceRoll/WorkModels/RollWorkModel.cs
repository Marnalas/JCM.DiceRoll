using DiceRoll.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.WorkModels
{
    public class RollWorkModel : IWorkModel
    {

        public ICollection<AttackerWorkModel> Attackers { get; set; }

        public ICollection<DefenderWorkModel> Defenders { get; set; }

        public int Margin { get; set; }

    }
}
