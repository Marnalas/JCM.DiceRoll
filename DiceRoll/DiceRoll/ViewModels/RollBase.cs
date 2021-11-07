﻿using DiceRoll.BLL;
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

        public void AddAttack()
        {
            Roll.AddAttacker();
        }

        public void AddSave()
        {
            Roll.AddDefender();
        }

        public void HandleValidSubmit()
        {
            Roll.CalculateRoll();
        }

    }
}
