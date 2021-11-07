using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.DataModels
{
    public class Result
    {

        public double Attempts { get; set; }

        public double SuccessProbability { get; set; }

        public double Initials { get; set; }

        public double Additionals { get; set; }

        public double Totals { get => Initials + Additionals; }

        public override string ToString() => $@"With a success probability of {SuccessProbability:0.000},
            out of {Attempts:0.000} attempts,
            {Initials:0.000} were initially successful.
            {(Additionals != default ? $@" {Additionals:0.000} rerolls were sucessful. There are {Totals:0.000} successful throws in total." : " No rerolls.")}";

    }
}
