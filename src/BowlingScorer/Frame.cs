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

        public override string ToString()
        {
            if (Rolls.Length == 3)
            {
                var output = (Rolls[0] == 10) ? "X" : Rolls[0].ToString();
                output += IsSpare ? "/" : Rolls[2] == 10 ? "X" : Rolls[2].ToString();
                output += Rolls[2] == 10 ? "X" : Rolls.Skip(1).Take(2).Sum() == 10 ? "/" : Rolls[2].ToString();
                return output;
            }
            else
            {
                if (IsSpare)
                    return String.Format("{0} /", Rolls[0]);
                else if (IsStrike)
                {
                    if (Rolls.Length == 1)
                        return String.Format(" X ");
                    else
                    {
                        return "X" + (Rolls[1] == 10 ? "X" : Rolls[1].ToString()) + " ";
                    }
                         
                }
            }
            return String.Join(" ", Rolls) + (Rolls.Length == 1 ? "  " : "");
        }
    }
}
