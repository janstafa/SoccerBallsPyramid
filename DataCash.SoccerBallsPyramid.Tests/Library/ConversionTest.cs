using DataCash.SoccerBallsPyramid.Library;
using NUnit.Framework;

namespace DataCash.SoccerBallsPyramid.Tests.Library
{
    [TestFixture, Category("UnitTest"), Timeout(50)]
    public class ConversionTest
    {
        [Test]
        public void ConvertFootToCentimeters()
        {
            //asign
            const double lengthInFoot = 6; //in foot

            //action
            var lengthInCm = Conversion.FootToCentimeters(lengthInFoot);

            //assert
            Assert.AreEqual(182.88d, lengthInCm, "Length in Cm is nor correct!");
        }

    }
}