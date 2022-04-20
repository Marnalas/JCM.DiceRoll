using DiceRoll.Data;
using System.Collections.Generic;

namespace DiceRoll.BLL.Steps
{
    public abstract class StepExecuter<T> : IStepExecuter
        where T : System.Enum
    {

        protected readonly IStepExecuter NextStepExecuter;
        protected readonly Option<T> Option;

        public StepExecuter(IStepExecuter stepExecuter, Option<T> option)
        {
            NextStepExecuter = stepExecuter;
            Option = option;
        }

        public virtual void Execute(StepResult stepResult)
        {
            StepExecute(stepResult);
            if (stepResult != null)
                NextStepExecuter.Execute(stepResult);
        }

        private static double GetSuccessProbabilityFromAttackSkill(int attackSkill)
            => (6 - attackSkill + 1) / (double)6;

        protected abstract void StepExecute(StepResult stepResult);

        protected void Reroll(
            double quantity,
            int cap,
            double successProbability,
            bool hasReroll,
            Reroll reroll,
            ref bool hasUsedSingleReroll)
        {
            var initials = quantity * GetSuccessProbabilityFromAttackSkill(cap);
            if (hasReroll)
                switch (reroll.RerollType)
                {
                    case RerollType.AllFails:
                        initials += (quantity - initials) * successProbability;
                        break;
                    case RerollType.SingleFail:
                        if (!hasUsedSingleReroll && initials <= quantity - 1)
                        {
                            initials += successProbability;
                            hasUsedSingleReroll = true;
                        }
                        break;
                    case RerollType.SpecificValue:
                        if (reroll.Value < cap)
                            initials += quantity / (double)6 * successProbability;
                        break;
                }
        }

    }
}
