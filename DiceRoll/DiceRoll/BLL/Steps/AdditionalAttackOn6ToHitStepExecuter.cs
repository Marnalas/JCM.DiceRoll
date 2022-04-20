using DiceRoll.Data;
using System.Collections.Generic;
using System.Linq;

namespace DiceRoll.BLL.Steps
{
    public class AdditionalAttackOn6ToHitStepExecuter : StepExecuter<AttackerOptionType>
    {

        public AdditionalAttackOn6ToHitStepExecuter(IStepExecuter stepExecuter, Option<AttackerOptionType> option)
            : base(stepExecuter, option) { }

        protected override void StepExecute(StepResult stepResult)
        {
            stepResult.SucessfulHits += (stepResult.Attempts * 1/6 * Option.Value.Value) * stepResult.SuccessProbability;
        }

    }
}
