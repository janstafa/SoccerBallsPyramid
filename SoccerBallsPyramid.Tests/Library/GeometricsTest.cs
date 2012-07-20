using NUnit.Framework;
using SoccerBallsPyramid.Library;

namespace SoccerBallsPyramid.Tests.Library
{
    [TestFixture, Category("UnitTest"), Timeout(50)]
    public class GeometricsTest
    {
        [Test]
        public void CountLenghOfPyramidSide()
        {
            //asign
            const double heigh = 182.9; //in cm

            //action
            var calculateLengthOfSideOfRegularTetrahedron = Geometrics.CalculateLengthOfSideOfRegularTetrahedron(heigh);

            //assert
            Assert.AreEqual(224.00583697752168d, calculateLengthOfSideOfRegularTetrahedron, "Heigh is not the same!");
        }


        [Test]
        public void CalculatePyramidSide()
        {
            //asign
            const double ballDiameter = 22; //in cm

            //action
            var calculatedTetrahedronHigh = Geometrics.CalculateTetrahedronHigh(ballDiameter);

            //assert
            Assert.AreEqual(17.962924780409971d, calculatedTetrahedronHigh, "Length is not the same!");
        }

    }
}
