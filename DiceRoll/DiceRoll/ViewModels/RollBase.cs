using DiceRoll.BLL;
using DiceRoll.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.ViewModels
{
    public class RollBase : Base
    {

        public Roll Roll { get; set; }

        protected override void Initialize()
        {
            Roll = new Roll();
        }

        protected async Task AddAttacker_Click()
        {
            Roll.AddAttacker();
        }

        protected async Task AddDefender_Click()
        {
            Roll.AddDefender();
        }

        protected async Task AttackerMovedUp(int order)
        {
            Roll.MoveUpAttacker(order);
        }

        protected async Task DefenderMovedUp(int order)
        {
            Roll.MoveUpDefender(order);
        }

        protected async Task AttackerMovedDown(int order)
        {
            Roll.MoveDownAttacker(order);
        }

        protected async Task DefenderMovedDown(int order)
        {
            Roll.MoveDownDefender(order);
        }

        protected async Task AttackerDuplicated(int order)
        {
            Roll.DuplicateAttacker(order);
        }

        protected async Task DefenderDuplicated(int order)
        {
            Roll.DuplicateDefender(order);
        }

        protected async Task AttackerDeleted(int order)
        {
            Roll.RemoveAttacker(order);
        }

        protected async Task DefenderDeleted(int order)
        {
            Roll.RemoveDefender(order);
        }

        protected async Task HandleValidSubmit()
        {
            Roll.CalculateRoll();
        }

    }
}
