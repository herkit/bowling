using System.Collections.Generic;
using System.Linq;

namespace BowlingScorer
{
    public class Scorer
    {
        private const int LastFrameIndex = 9;
        private const int MaxFrameCount = 10;

        public static IEnumerable<Frame> ScoreFrames(params int[] rolls)
        {
            var currentRoll = 0;
            var frameIndex = 0;
            while (currentRoll < rolls.Length && frameIndex < MaxFrameCount)
            {
                var isStrike = rolls.ElementAt(currentRoll) == 10;
                var isSpare = rolls.Skip(currentRoll).Take(2).Sum() == 10;
                var isOnLastFrame = frameIndex == LastFrameIndex;

                var rollsInScore = isStrike || isSpare ? 3 : 2;
                var rollsInFrame = isStrike ? 1 : 2;
                if (isOnLastFrame)
                    rollsInFrame = isStrike || isSpare ? 3 : 2;

                yield return new Frame
                {
                    Rolls = rolls.Skip(currentRoll).Take(rollsInFrame).ToArray(),
                    Score = rolls.Skip(currentRoll).Take(rollsInScore).Sum()
                };

                currentRoll += rollsInFrame;
                frameIndex++;
            }
        }
    }
}
