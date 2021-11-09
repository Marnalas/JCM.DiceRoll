using DiceRoll.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.ViewModels
{
    public abstract class Base : ComponentBase
    {

        private Guid Id { get; set; }

        public string ComponentId { get => Id.ToString(); }

        public Dictionary<RerollType, string> RerollTypeDisplayNamesDictionary { get; }
            = new Dictionary<RerollType, string>
            {
                { RerollType.AllFails, "Reroll all fails" },
                { RerollType.SingleFail, "Reroll one fail" },
                { RerollType.SpecificValue, "Reroll all dices with a specific value" }
            };

        public Dictionary<AttackerOptionType, string> AttackerOptionTypeDisplayNamesDictionary { get; }
            = new Dictionary<AttackerOptionType, string>
            {
                { AttackerOptionType.AdditionalHitOn6ToHit, "Additional hits on 6 to hit" },
                { AttackerOptionType.AutoWoundOn6ToHit, "Auto wound on 6 to hit" },
                { AttackerOptionType.MWOn6ToWound, "Mortal wounds on 6 to wound" },
                { AttackerOptionType.APOn6ToWound, "Reroll all dices with a specific value" },
                { AttackerOptionType.IgnoresCover, "Ignore covers" },
                { AttackerOptionType.IgnoresInvulnSave, "Ignore invuln. saves" },
                { AttackerOptionType.DenseCover, "Target is behind dense cover" }
            };

        public Dictionary<DefenderOptionType, string> DefenderOptionTypeDisplayNamesDictionary { get; }
            = new Dictionary<DefenderOptionType, string>
            {
                { DefenderOptionType.Cover, "Light/heavy cover" }
            };

        protected override Task OnInitializedAsync()
        {
            Initialize();
            Id = Guid.NewGuid();
            return base.OnInitializedAsync();
        }

        protected virtual void Initialize() { }

    }
}
