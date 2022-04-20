using DiceRoll.Data;
using System.Collections.Generic;
using System.Linq;

namespace DiceRoll.BLL.Steps
{
    public class HitStepExecuter : StepExecuter<AttackerOptionType>
    {

        public HitStepExecuter(IStepExecuter stepExecuter, Option<AttackerOptionType> option)
            : base(stepExecuter, option) { }

        protected override void StepExecute(StepResult stepResult)
        {
            stepResult.SucessfulHits += stepResult.Attempts * stepResult.SuccessProbability;
        }

    }
}
