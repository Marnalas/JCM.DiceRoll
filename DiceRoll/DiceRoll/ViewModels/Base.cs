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

        public Dictionary<RerollType, string> RerollTypeDisplayNamesDictionary { get; }
            = new Dictionary<RerollType, string>
            {
                { RerollType.AllFails, "Reroll all fails" },
                { RerollType.SingleFail, "Reroll one fail" },
                { RerollType.SpecificValue, "Reroll all dices with a specific value" }
            };

        protected override Task OnInitializedAsync()
        {
            Initialize();
            return base.OnInitializedAsync();
        }

        protected virtual void Initialize() { }

    }
}
