using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScorer
{
    public class Program
    {
        public static void Main()
        {
            var gameOn = true;
            var rolls = new List<int>();
            while (gameOn)
            {
                Console.WriteLine("Enter roll [0-9] or [S]trike:");

                var key = Console.ReadKey();

                var roll = "0123456789S".IndexOf(key.KeyChar.ToString().ToUpper());
                if (roll >= 0)
                {
                    rolls.Add(roll);
                }

                var frames = Scorer.ScoreFrames(rolls.ToArray()).ToList();
                
                PresentFrames(frames);

                gameOn = (frames.Count() < 10 || ((frames[9].IsStrike || frames[9].IsSpare) && frames[9].Rolls.Length < 3) );
            }

            Console.WriteLine("Game finished!");
            Console.ReadLine();
        }

        private static void PresentFrames(IEnumerable<Frame> frames)
        {
            var scoreline = "";
            var rollsline = "";
            foreach (var frame in frames)
            {
                rollsline += frame.ToString();
                rollsline += String.Format(" | ");

                scoreline += String.Format("{0,3}", frame.Score) + " | ";

            }

            rollsline += " Total ";
            scoreline += String.Format("  {0,3}  ", frames.Sum(f => f.Score));

            Console.Clear();
            Console.WriteLine(rollsline);
            Console.WriteLine(scoreline);

        }
    }
}
