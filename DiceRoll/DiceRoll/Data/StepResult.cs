namespace DiceRoll.Data
{
    public class StepResult
    {

        public double Attempts { get; set; }

        public double SuccessProbability { get; set; }

        public double SucessfulHits { get; set; }

        public double SucessfulWounds { get; set; }

        public double SucessfulWoundsWithAP { get; set; }

        public int AP { get; set; }

        public int Damages { get; set; }

        public int MortalWounds { get; set; }

        public StepResult(double attempts
            , double successProbability
            , int ap
            , int damages)
        {
            Attempts = attempts;
            SuccessProbability = successProbability;
            SucessfulHits = 0;
            SucessfulWounds = 0;
            SucessfulWoundsWithAP = 0;
            AP = ap;
            Damages = damages;
            MortalWounds = 0;
        }

        public override string ToString() => $@"With a success probability of {SuccessProbability:0.000},
            out of {Attempts:0.000} attempts,
            {SucessfulHits:0.000} were successful.";

    }
}
