using NUnit.Framework;
using Should;

namespace BowlingScorer.Tests
{
    [TestFixture]
    public class FrameTests
    {
        [Test]
        public void Should_be_able_to_query_frame_if_it_is_a_strike()
        {
            var frame = new Frame { Rolls = new[] { 10 } };
            frame.IsStrike.ShouldEqual(true);
        }

        [Test]
        public void Should_be_able_to_query_frame_if_it_is_a_spare()
        {
            var frame = new Frame { Rolls = new[] { 5, 5 } };
            frame.IsStrike.ShouldEqual(false);
            frame.IsSpare.ShouldEqual(true);
        }

        [Test]
        public void Should_be_able_to_identify_spares_in_last_frame()
        {
            var frame = new Frame { Rolls = new[] { 4, 6, 2 } };
            frame.IsStrike.ShouldEqual(false);
            frame.IsSpare.ShouldEqual(true);
        }


        [Test]
        public void ToString_should_return_string_representation_of_frame()
        {
            new Frame { Rolls = new[] { 5, 5 } }.ToString().ShouldEqual("5 /");
            new Frame { Rolls = new[] { 10 } }.ToString().ShouldEqual(" X ");
            new Frame { Rolls = new[] { 0, 3 } }.ToString().ShouldEqual("0 3");
            new Frame { Rolls = new[] { 5, 5, 2 } }.ToString().ShouldEqual("5/2");
            new Frame { Rolls = new[] { 10, 10, 10 } }.ToString().ShouldEqual("XXX");
            new Frame { Rolls = new[] { 10, 10 } }.ToString().ShouldEqual("XX ");
        }
    }
}
