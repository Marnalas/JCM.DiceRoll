using DiceRoll.Data;
using DiceRoll.Extensions;
using System.Collections.Generic;

namespace DiceRoll.WorkModels
{
    public class DefenderWorkModel : IWorkModel
    {

        public int Quantity { get; set; }

        public int Wounds { get; set; }

        public int SaveCap { get; set; }

        public int InvlSaveCap { get; set; }

        public bool HasSaveReroll { get => SaveReroll != null; }

        public Reroll SaveReroll { get; set; }

        public bool HasFeelNoPain { get => FeelNoPainCap != null; }

        public int? FeelNoPainCap { get; set; }

        public Dictionary<DefenderOptionType, Option<DefenderOptionType>> OptionsDictionary { get; set; }

        public StepResult SavesResult { get; set; }

        public StepResult FeelNoPainResult { get; set; }

    }
}
