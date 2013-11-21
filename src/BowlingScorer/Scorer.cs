using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScorer
{
    public class Scorer
    {
        public static IEnumerable<Frame> Score(params int[] rolls)
        {
            var offset = 0;

            while (offset < rolls.Length)
            {
                var countRolls = 2;
                var frameRolls = 2;
                if (rolls[offset] == 10)
                {
                    frameRolls = 1;
                    countRolls = 3;
                }

                var frame = new Frame
                {
                    Score = rolls.Skip(offset).Take(countRolls).Sum()
                };

                yield return frame;

                offset += frameRolls;
            }
        }
    }
}
