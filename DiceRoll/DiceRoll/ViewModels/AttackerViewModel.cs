using DiceRoll.Data;
using DiceRoll.Extensions;
using DiceRoll.WorkModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiceRoll.ViewModels
{
    public class AttackerViewModel : IOrderable, IWorkModelConvertible<AttackerWorkModel>
    {

        [Display(Name = "Order")]
        public int Order { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "WS or BS")]
        public int AttackSkill { get; set; } = 3;

        [Display(Name = "Hit reroll")]
        public bool HasHitReroll { get => HitRerollType != null; set => HitRerollType = value ? RerollType.AllFails : null; }

        public RerollType? HitRerollType { get; set; }

        [Display(Name = "Wound on")]
        public int WoundCap { get; set; } = 4;

        [Display(Name = "Wound reroll")]
        public bool HasWoundReroll { get => WoundRerollType != null; set => WoundRerollType = value ? RerollType.AllFails : null; }

        public RerollType? WoundRerollType { get; set; }

        [Display(Name = "AP")]
        public int AP { get; set; }

        [Display(Name = "Damages")]
        public int Damages { get; set; }

        [Display(Name = "Options")]
        public Dictionary<AttackerOptionType, Option<AttackerOptionType>> OptionsDictionary { get; set; }
            = EnumExtensions.GetEnumDictionary<AttackerOptionType>();

        public string HitResult { get; set; }

        public string WoundResult { get; set; }

        public AttackerWorkModel ConvertToWorkModel()
            => new()
            {
                Quantity = Quantity,
                AttackSkill = AttackSkill,
                HitReroll = HitRerollType.HasValue ? new Reroll { RerollType = HitRerollType.Value } : null,
                WoundCap = WoundCap,
                WoundReroll = WoundRerollType.HasValue ? new Reroll { RerollType = WoundRerollType.Value } : null,
                AP = AP,
                Damages = Damages,
                OptionsDictionary = OptionsDictionary
            };

    }
}
