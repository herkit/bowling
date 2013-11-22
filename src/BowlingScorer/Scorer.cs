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
        public static IEnumerable<Frame> ScoreFrames(params int[] rolls)
        {
            var frameOffset = 0;
            var frameNo = 1;
            while (frameOffset < rolls.Length && frameNo < 11)
            {
                var rollsInScore = 2; var rollsInFrame = 2;
                if (rolls[frameOffset] == 10)
                {
                    rollsInFrame = (frameNo == 10) ? 3 : 1; 
                    rollsInScore = 3;
                } 
                else if (rolls.Skip(frameOffset).Take(2).Sum() == 10)
                    rollsInScore = 3;

                var frame = new Frame
                {
                    Rolls = rolls.Skip(frameOffset).Take(rollsInFrame).ToArray(),
                    Score = rolls.Skip(frameOffset).Take(rollsInScore).Sum()
                };

                yield return frame;

                frameOffset += rollsInFrame;
                frameNo++;
            }
        }
    }
}
