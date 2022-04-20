using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.Data
{
    public enum RerollType
    {
        [Description("Reroll all fails")]
        AllFails = 0,
        [Description("Reroll one fail")]
        SingleFail = 1,
        [Description("Reroll all dices with a specific value")]
        SpecificValue = 2
    }
}
