using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.DataModels

{
    public class Attacker
    {
        public int Quantity { get; set; }

        public int AttackSkill { get; set; } = 3;

        public bool HasHitReroll { get => HitReroll != null; set => HitReroll = value ? new Reroll() : null; }

        public Reroll HitReroll { get; set; }

        public int WoundCap { get; set; } = 4;

        public bool HasWoundReroll { get => WoundReroll != null; set => WoundReroll = value ? new Reroll() : null; }

        public Reroll WoundReroll { get; set; }

        public int AP { get; set; }

        public int Damages { get; set; }

        public int Order { get; set; }

        public Result HitResult { get; set; }

        public Result WoundResult { get; set; }

        public double TotalDamages { get => WoundResult.Totals * Damages; }

    }
}
