using DiceRoll.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.BLL
{
    public static class RollCalculatorService
    {

        private static double getSuccessProbabilityFromAttackSkill(int attackSkill)
            => (6 - attackSkill + 1) / (double)6;

        private static Result calculateStep(
            double quantity,
            int cap,
            bool hasReroll,
            Reroll reroll,
            ref bool hasUsedSingleReroll)
        {
            var attackerResult = new Result { Attempts = quantity, SuccessProbability = getSuccessProbabilityFromAttackSkill(cap) };
            attackerResult.Initials = quantity * attackerResult.SuccessProbability;
            if (hasReroll)
                switch (reroll.RerollType)
                {
                    case RerollType.AllFails:
                        attackerResult.Additionals = (quantity - attackerResult.Initials) * attackerResult.SuccessProbability;
                        break;
                    case RerollType.SingleFail:
                        if (!hasUsedSingleReroll && attackerResult.Initials <= quantity - 1)
                        {
                            attackerResult.Additionals = 1 * attackerResult.SuccessProbability;
                            hasUsedSingleReroll = true;
                        }
                        break;
                    case RerollType.SpecificValue:
                        if (reroll.Value < cap)
                            attackerResult.Additionals = quantity / (double)6 * attackerResult.SuccessProbability;
                        break;
                }
            return attackerResult;
        }

        public static void CalculateRoll(this Roll roll)
        {
            var hasUsedSingleFailReroll = false;
            foreach (var attacker in roll.AttackersList.OrderBy(a => a.Order))
            {
                attacker.HitResult = calculateStep(attacker.Quantity, attacker.AttackSkill, attacker.HasHitReroll, attacker.HitReroll, ref hasUsedSingleFailReroll);
                attacker.WoundResult = calculateStep(attacker.HitResult.Totals, attacker.WoundCap, attacker.HasWoundReroll, attacker.WoundReroll, ref hasUsedSingleFailReroll);
            }

            hasUsedSingleFailReroll = false;
            foreach (var defender in roll.DefendersList.OrderBy(d => d.Order))
            {
                defender.SavesResult = calculateStep(defender.Quantity, defender.SaveCap, defender.HasSaveReroll, defender.SaveReroll, ref hasUsedSingleFailReroll);
                //if (defender.HasFeelNoPain)
                //    defender.FeelNoPainResult = calculateStep(defender.HitResult.Totals, defender.WoundCap, defender.HasWoundReroll, defender.WoundReroll, ref hasUsedSingleFailReroll);
            }
        }

    }
}
