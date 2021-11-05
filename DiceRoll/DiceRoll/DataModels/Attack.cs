using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.DataModels

{
    public class Attack
    {
        public int HitCap { get; set; } = 3;

        public Reroll HitReroll { get; set; }

        public int WoundCap { get; set; } = 4;

        public Reroll WoundReroll { get; set; }

    }
}
