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
                yield return new Frame()
                {
                    Score = rolls.Skip(offset).Take(2).Sum()
                };
                offset += 2;
            }
        }
    }
}
