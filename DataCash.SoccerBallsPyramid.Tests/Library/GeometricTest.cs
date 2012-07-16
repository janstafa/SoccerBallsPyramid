using DataCash.SoccerBallsPyramid.Library;
using NUnit.Framework;

namespace DataCash.SoccerBallsPyramid.Tests.Library
{
    [TestFixture, Category("UnitTest"), Timeout(50)]
    public class GeometricTest
    {
        [Test]
        public void CountLenghOfPyramidSide()
        {
            //asign
            const double heigh = 182.9; //in cm

            //action
            var calculateLengthOfSideOfRegularTetrahedron = Geometric.CalculateLengthOfSideOfRegularTetrahedron(heigh);

            //assert
            Assert.AreEqual(224.00583697752168d, calculateLengthOfSideOfRegularTetrahedron, "Heigh is not the same!");
        }


        [Test]
        public void CalculatePyramidSide()
        {
            //asign
            const double ballDiameter = 22; //in cm

            //action
            var calculatedTetrahedronHigh = Geometric.CalculateTetrahedronHigh(ballDiameter);

            //assert
            Assert.AreEqual(17.962924780409971d, calculatedTetrahedronHigh, "Length is not the same!");
        }

    }
}
