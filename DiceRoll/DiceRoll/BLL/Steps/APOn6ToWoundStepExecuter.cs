using DiceRoll.Data;

namespace DiceRoll.BLL.Steps
{
    public class APOn6ToWoundStepExecuter : StepExecuter<AttackerOptionType>
    {

        public APOn6ToWoundStepExecuter(IStepExecuter stepExecuter, Option<AttackerOptionType> option)
            : base(stepExecuter, option) { }

        protected override void StepExecute(StepResult stepResult)
        {
            stepResult.SucessfulWoundsWithAP += stepResult.SucessfulHits * 1 / 6;
        }

    }
}
