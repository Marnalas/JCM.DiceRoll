using DiceRoll.Data;
using System.Collections.Generic;

namespace DiceRoll.BLL.Steps
{
    public interface IStepExecuter
    {

        public void Execute(StepResult stepResult);

    }
}
