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

    }
}
