using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Should;

namespace BowlingScorer.Tests
{
    [TestFixture]
    public class ScorerTests
    {
        [Test]
        public void Should_score_first_frame()
        {
            List<Frame> frames = Scorer.Score(1, 2).ToList();
            frames[0].Score.ShouldEqual(3);
        }
    }
}
