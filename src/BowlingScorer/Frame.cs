using System;
using System.Linq;

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
                return (Rolls.First() == 10);
            }
        }

        public bool IsSpare
        {
            get
            {
                return (Rolls.Take(2).Sum() == 10 && Rolls.ElementAt(0) != 10);
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
            if (Rolls.Count() == 3)
            {
                var output = IsStrike ? "X" : Rolls.First().ToString();
                output += IsSpare ? "/" : Rolls.ElementAt(2) == 10 ? "X" : Rolls.ElementAt(2).ToString();
                output += Rolls.ElementAt(2) == 10 ? "X" : Rolls.Skip(1).Take(2).Sum() == 10 ? "/" : Rolls.ElementAt(2).ToString();
                return output;
            }

            if (IsSpare)
                return String.Format("{0} /", Rolls[0]);
                
            if (IsStrike)
            {
                if (Rolls.Count() == 1)
                    return String.Format(" X ");
                return "X" + (Rolls.First() == 10 ? "X" : Rolls.ElementAt(1).ToString()) + " ";
            }

            return String.Join(" ", Rolls) + (Rolls.Count() == 1 ? "  " : "");
        }
    }
}
