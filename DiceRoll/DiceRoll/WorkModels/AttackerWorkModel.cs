using DiceRoll.Data;
using DiceRoll.Extensions;
using System.Collections.Generic;

namespace DiceRoll.WorkModels

{
    public class AttackerWorkModel : IWorkModel
    {

        public int Quantity { get; set; }

        public int AttackSkill { get; set; }

        public bool HasHitReroll { get => HitReroll != null; }

        public Reroll HitReroll { get; set; }

        public int WoundCap { get; set; }

        public bool HasWoundReroll { get => WoundReroll != null; }

        public Reroll WoundReroll { get; set; }

        public int AP { get; set; }

        public int Damages { get; set; }

        public Dictionary<AttackerOptionType, Option<AttackerOptionType>> OptionsDictionary { get; set; }

        public StepResult HitResult { get; set; }

        public StepResult WoundResult { get; set; }

        public double TotalDamages { get => (WoundResult?.SucessfulHits ?? 0) * Damages; }

    }
}
