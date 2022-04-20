using DiceRoll.Data;
using DiceRoll.WorkModels;
using System.Linq;

namespace DiceRoll.BLL.Services
{
    public static class RollCalculatorService
    {

        private static double GetSuccessProbabilityFromAttackSkill(int attackSkill)
            => (6 - attackSkill + 1) / (double)6;

        //private static StepResult CalculateStep(
        //    double quantity,
        //    int cap,
        //    bool hasReroll,
        //    Reroll reroll,
        //    ref bool hasUsedSingleReroll)
        //{
        //    var attackerResult = new StepResult { Attempts = quantity, SuccessProbability = GetSuccessProbabilityFromAttackSkill(cap) };
        //    attackerResult.Initials = quantity * attackerResult.SuccessProbability;
        //    //if (hasReroll)
        //    //    switch (reroll.RerollType)
        //    //    {
        //    //        case RerollType.AllFails:
        //    //            attackerResult.Additionals = (quantity - attackerResult.Initials) * attackerResult.SuccessProbability;
        //    //            break;
        //    //        case RerollType.SingleFail:
        //    //            if (!hasUsedSingleReroll && attackerResult.Initials <= quantity - 1)
        //    //            {
        //    //                attackerResult.Additionals = 1 * attackerResult.SuccessProbability;
        //    //                hasUsedSingleReroll = true;
        //    //            }
        //    //            break;
        //    //        case RerollType.SpecificValue:
        //    //            if (reroll.Value < cap)
        //    //                attackerResult.Additionals = quantity / (double)6 * attackerResult.SuccessProbability;
        //    //            break;
        //    //    }
        //    return attackerResult;
        //}

        public static void CalculateRoll(RollWorkModel roll)
        {
            //var rollResult = new Result();
            var hasUsedSingleFailReroll = false;
            foreach (var attacker in roll.Attackers)
            {
                var hitStepResult = new StepResult(
                    attacker.Quantity
                    , GetSuccessProbabilityFromAttackSkill(attacker.AttackSkill)
                    , attacker.AP
                    , attacker.Damages);

            }

            hasUsedSingleFailReroll = false;
            foreach (var defender in roll.Defenders)
            {
            }
            //return rollResult;
        }

    }
}
