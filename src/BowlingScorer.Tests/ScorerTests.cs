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
            List<Frame> frames = Scorer.ScoreFrames(1, 2).ToList();
            frames[0].Score.ShouldEqual(3);
        }

        [Test]
        public void Should_score_three_frames()
        {
            var frames = Scorer.ScoreFrames(1, 2, 3, 4, 2, 0).ToList();
            frames[0].Score.ShouldEqual(3);
            frames[1].Score.ShouldEqual(7);
            frames[2].Score.ShouldEqual(2);
        }

        [Test]
        public void Should_score_strikes()
        {
            var frames = Scorer.ScoreFrames(10, 6, 2).ToList();
            frames[0].Score.ShouldEqual(18);
            frames[1].Score.ShouldEqual(8);
        }

        [Test]
        public void Should_score_max()
        {
            var frames = Scorer.ScoreFrames(10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10).ToList();
            frames.Count.ShouldEqual(10);
            frames[9].Score.ShouldEqual(30);
            frames.Sum(f => f.Score).ShouldEqual(300);
        }

        [Test]
        public void Should_score_spares()
        {
            var frames = Scorer.ScoreFrames(5, 5, 3, 7, 3, 0).ToList();
            frames.Count.ShouldEqual(3);
            frames[0].Score.ShouldEqual(13);
            frames[1].Score.ShouldEqual(13);
            frames[2].Score.ShouldEqual(3);
        }

    }
}
