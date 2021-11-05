using DiceRoll.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.ViewModels
{
    public class AttackBase : ComponentBase
    {
        [Parameter]
        public Attack Attack { get; set; }

        public bool HasHitReroll { get; set; } = false;

        public bool HasWoundReroll { get; set; } = false;

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

    }
}
