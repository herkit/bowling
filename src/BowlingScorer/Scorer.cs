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
        private const int LastFrameIndex = 9;
        private const int MaxFrameCount = 10;

        public static IEnumerable<Frame> ScoreFrames(params int[] rolls)
        {
            var frameOffset = 0;
            var frameIndex = 0;
            while (frameOffset < rolls.Length && frameIndex < MaxFrameCount)
            {
                var rollsInScore = 2; var rollsInFrame = 2;

                if (rolls[frameOffset] == 10)
                {
                    rollsInFrame = (frameIndex == LastFrameIndex) ? 3 : 1; 
                    rollsInScore = 3;
                } 
                else if (rolls.Skip(frameOffset).Take(2).Sum() == 10)
                {
                    rollsInFrame = (frameIndex == LastFrameIndex) ? 3 : 2;
                    rollsInScore = 3;
                }

                var frame = new Frame
                {
                    Rolls = rolls.Skip(frameOffset).Take(rollsInFrame).ToArray(),
                    Score = rolls.Skip(frameOffset).Take(rollsInScore).Sum()
                };

                yield return frame;

                frameOffset += rollsInFrame;
                frameIndex++;
            }
        }
    }
}
