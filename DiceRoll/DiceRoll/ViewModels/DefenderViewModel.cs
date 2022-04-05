using DiceRoll.Data;
using DiceRoll.Extensions;
using DiceRoll.WorkModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiceRoll.ViewModels
{
    public class DefenderViewModel : IOrderable, IWorkModelConvertible<DefenderWorkModel>
    {

        public int Order { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Wounds")]
        public int Wounds { get; set; } = 1;

        [Display(Name = "Save on")]
        public int SaveCap { get; set; } = 4;

        [Display(Name = "Invln. save on")]
        public int InvlSaveCap { get; set; } = 4;

        [Display(Name = "Save reroll")]
        public bool HasSaveReroll { get => SaveRerollType != null; set => SaveRerollType = value ? RerollType.AllFails : null; }

        public RerollType? SaveRerollType { get; set; }

        [Display(Name = "Feel no pain")]
        public bool HasFeelNoPain { get; set; }

        public int? FeelNoPainCap { get; set; }

        [Display(Name = "Options")]
        public Dictionary<DefenderOptionType, Option<DefenderOptionType>> OptionsDictionary { get; set; }
            = EnumExtensions.GetEnumDictionary<DefenderOptionType>();

        public string SavesResult { get; set; }

        public string FeelNoPainResult { get; set; }

        public DefenderWorkModel ConvertToWorkModel()
            => new()
            {
                Quantity = Quantity,
                Wounds = Wounds,
                SaveCap = SaveCap,
                InvlSaveCap = InvlSaveCap,
                SaveReroll = SaveRerollType.HasValue ? new Reroll { RerollType = SaveRerollType.Value } : null,
                FeelNoPainCap = FeelNoPainCap,
                OptionsDictionary = OptionsDictionary
            };

    }
}
