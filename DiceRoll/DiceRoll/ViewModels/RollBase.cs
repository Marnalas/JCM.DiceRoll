using DiceRoll.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.ViewModels
{
    public class RollBase : ComponentBase
    {

        public Roll Roll { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitializeRoll();
            return base.OnInitializedAsync();
        }

        private void InitializeRoll()
        {
            Roll = new Roll();
        }

        public void AddAttack()
        {
            Roll.AddAttack();
        }

    }
}
