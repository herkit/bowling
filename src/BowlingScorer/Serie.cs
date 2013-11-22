using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScorer
{
    public class Serie
    {
        public List<Frame> Frames { get { return _frames;  } }
        private List<int> _rolls = new List<int>();
        private List<Frame> _frames = new List<Frame>();

        public void AddRoll(int roll)
        {
            _rolls.Add(roll);
            _frames = Scorer.ScoreFrames(_rolls.ToArray()).ToList();
        }

    }
}
