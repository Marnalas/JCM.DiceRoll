using DiceRoll.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.DataModels
{
    public class Defender
    {
        public int Quantity { get; set; }

        public int Wounds { get; set; } = 1;

        public int SaveCap { get; set; } = 4;

        public int InvlSaveCap { get; set; } = 4;

        public bool HasSaveReroll { get => SaveReroll != null; set => SaveReroll = value ? new Reroll() : null; }

        public Reroll SaveReroll { get; set; }

        public bool HasFeelNoPain { get => FeelNoPainCap != null; set => FeelNoPainCap = value ? 6 : null; }

        public int? FeelNoPainCap { get; set; }

        public Dictionary<DefenderOptionType, Option<DefenderOptionType>> OptionsDictionary { get; set; }
            = EnumExtensions.GetEnumDictionary<DefenderOptionType>();

        public int Order { get; set; }

        public Result SavesResult { get; set; }

        public Result FeelNoPainResult { get; set; }

    }
}
