using DiceRoll.Data;

namespace DiceRoll.BLL.Steps
{
    public class MWOn6ToWoundStepExecuter : StepExecuter<AttackerOptionType>
    {

        public MWOn6ToWoundStepExecuter(IStepExecuter stepExecuter, Option<AttackerOptionType> option)
            : base(stepExecuter, option) { }

        protected override void StepExecute(StepResult stepResult)
        {
            stepResult.SucessfulWounds += stepResult.SucessfulHits * 1 / 6 * Option.Value.Value;
        }

    }
}
