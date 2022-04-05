using DiceRoll.Data;

namespace DiceRoll.BLL.Steps
{
    public class AdditionalHitOn6ToHitStepExecuter : StepExecuter<AttackerOptionType>
    {

        public AdditionalHitOn6ToHitStepExecuter(IStepExecuter stepExecuter, Option<AttackerOptionType> option)
            : base(stepExecuter, option) { }

        protected override void StepExecute(StepResult stepResult)
        {
            stepResult.SucessfulHits += stepResult.Attempts * 1 / 6 * Option.Value.Value;
        }

    }
}
