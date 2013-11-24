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
    public class SerieTests
    {
        [Test]
        public void Should_be_able_to_add_roll()
        {
            var serie = new Serie();
            serie.AddRoll(10);
            serie.Frames.Count.ShouldEqual(1);
        }

        [Test]
        public void Should_identify_end_of_serie_with_strike_in_last_frame()
        {
            var serie = new Serie();
            for (var i = 0; i < 18; i++)
            {
                serie.AddRoll(3);
            }
            serie.AddRoll(5);
            serie.IsDone.ShouldBeFalse();
            serie.AddRoll(5);
            serie.IsDone.ShouldBeFalse();
            serie.AddRoll(5);
            serie.IsDone.ShouldBeTrue();
        }

        [Test]
        public void Should_identify_end_of_serie_with_no_strike_in_last_frame()
        {
            var serie = new Serie();
            for (var i = 0; i < 19; i++)
            {
                serie.AddRoll(3);
            }
            serie.IsDone.ShouldBeFalse();
            serie.AddRoll(3);
            serie.IsDone.ShouldBeTrue();
        }

    }
}
