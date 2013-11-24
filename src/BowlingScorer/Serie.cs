using System.Collections.Generic;
using System.Linq;

namespace BowlingScorer
{
    public class Serie
    {
        public List<Frame> Frames { get { return _frames;  } }
        private readonly List<int> _rolls = new List<int>();
        private List<Frame> _frames = new List<Frame>();

        public void AddRoll(int roll)
        {
            _rolls.Add(roll);
            _frames = Scorer.ScoreFrames(_rolls.ToArray()).ToList();
        }

        public bool IsDone
        {
            get
            {
                
                return IsOnLastFrame && LastFrameIsDone;
            }
        }

        private bool IsOnLastFrame { get { return _frames.Count == 10; } }

        private bool LastFrameIsDone
        {
            get {
                if (_frames.Last().IsStrikeOrSpare)
                    return _frames.Last().Rolls.Length == 3;
                return _frames.Last().Rolls.Length == 2;
            }
        }
    }
}
