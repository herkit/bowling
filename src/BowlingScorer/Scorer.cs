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
            yield return new Frame()
            {
                Score = rolls.Take(2).Sum()
            };
        }
    }
}
