using DiceRoll.Data;

namespace DiceRoll.BLL.Steps
{
    public class AutoWoundOn6ToHitStepExecuter : StepExecuter<AttackerOptionType>
    {

        public AutoWoundOn6ToHitStepExecuter(IStepExecuter stepExecuter, Option<AttackerOptionType> option)
            : base(stepExecuter, option) { }

        protected override void StepExecute(StepResult stepResult)
        {
            stepResult.SucessfulWounds += stepResult.Attempts * 1 / 6 * Option.Value.Value;
        }

    }
}
