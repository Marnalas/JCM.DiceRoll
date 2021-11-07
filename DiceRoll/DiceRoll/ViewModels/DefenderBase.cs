using DiceRoll.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.ViewModels
{
    public class DefenderBase : Base
    {
        [Parameter]
        public Defender Defender { get; set; }

    }
}
