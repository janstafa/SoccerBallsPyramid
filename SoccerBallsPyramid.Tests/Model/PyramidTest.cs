using System;
using NUnit.Framework;
using SoccerBallsPyramid.Model;

namespace SoccerBallsPyramid.Tests.Model
{
    [TestFixture, Category("UnitTest"), Timeout(50)]
    public class PyramidTest
    {
        [Test]
        public void ThrowExceptionInConstructorIfHighIsZeroOrNegative()
        {
            //asign
            const double highZero = 0; //in foot
            const double highNegative = -1; //in foot

            //action
             
            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Pyramid(highZero));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Pyramid(highNegative));
        }
    }
}