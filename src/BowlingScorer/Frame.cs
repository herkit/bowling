using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingScorer
{
    public class Frame
    {
        public int[] Rolls { get; set; }
        public int Score { get; set; }

        public bool IsStrike
        {
            get
            {
                return (Rolls[0] == 10);
            }
        }

        public bool IsSpare
        {
            get
            {
                return (Rolls.Take(2).Sum() == 10 && Rolls[0] != 10);
            }
        }

        public bool IsStrikeOrSpare
        {
            get
            {
                return (IsSpare || IsStrike);
            }
        }

        public override string ToString()
        {
            if (Rolls.Length == 3)
            {
                var output = IsStrike ? "X" : Rolls[0].ToString();
                output += IsSpare ? "/" : Rolls[2] == 10 ? "X" : Rolls[2].ToString();
                output += Rolls[2] == 10 ? "X" : Rolls.Skip(1).Take(2).Sum() == 10 ? "/" : Rolls[2].ToString();
                return output;
            }

            if (IsSpare)
                return String.Format("{0} /", Rolls[0]);
                
            if (IsStrike)
            {
                if (Rolls.Length == 1)
                    return String.Format(" X ");
                return "X" + (Rolls[1] == 10 ? "X" : Rolls[1].ToString()) + " ";
            }

            return String.Join(" ", Rolls) + (Rolls.Length == 1 ? "  " : "");
        }
    }
}
