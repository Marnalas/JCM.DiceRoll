using System.ComponentModel;

namespace DiceRoll.Data
{
    public enum AttackerOptionType
    {
        [Description("Hit modifier")]
        HitModifier = 0,
        [Description("Target is behind dense cover")]
        DenseCover = 1,
        [Description("Additional attacks on 6 to hit")]
        AdditionalAttackOn6ToHit = 2,
        [Description("Additional hits on 6 to hit")]
        AdditionalHitOn6ToHit = 3,
        [Description("Auto wound on 6 to hit")]
        AutoWoundOn6ToHit = 4,
        [Description("Wound modifier")]
        WoundModifier = 5,
        [Description("Mortal wounds on 6 to wound")]
        MWOn6ToWound = 6,
        [Description("-1AP on 6 to wound")]
        APOn6ToWound = 7,
        [Description("2 damages on save 3+ or better")]
        DamageOnSave3 = 8,
        [Description("Ignore covers")]
        IgnoresCover = 9,
        [Description("Ignore invuln. saves")]
        IgnoresInvulnSave = 10
    }
}