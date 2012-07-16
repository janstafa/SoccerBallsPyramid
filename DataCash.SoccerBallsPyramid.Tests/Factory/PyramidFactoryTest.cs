using DataCash.SoccerBallsPyramid.Factory;
using DataCash.SoccerBallsPyramid.Model;
using NUnit.Framework;

namespace DataCash.SoccerBallsPyramid.Tests.Factory
{
    [TestFixture, Category("UnitTest"), Timeout(50)]
    public class PyramidFactoryTest
    {
        [Test]
        public void NumberOfUsedBallsToBuildAFloor()
        {
            // asign
            const double startBallsNumber = 10;

            // action
            var numberOfUsedBallsToBuildFloor = PyramidFactory.GetNumberOfUsedBallsToBuildFloor(startBallsNumber);

            // assert
            Assert.AreEqual(55, numberOfUsedBallsToBuildFloor, "Number of used balls is not correct!");
        }


        [Test]
        public void TestTotalNumberOfBallsUsedToConstruction()
        {
            // asign
            const double startBallsNumber = 10;

            // action
            var sumOfUsedBallsToBuildPyramid = PyramidFactory.GetTotalNumberOfBallsUsedInConstruction(startBallsNumber);

            // assert
            Assert.AreEqual(220, sumOfUsedBallsToBuildPyramid, "Number of used balls is not correct!");
        }

        [Test]
        public void BuildPyramidAboutGivenHighWithBallsOfGivenDiameter()
        { 
            // asign
            var pyramidHigh = 6; //in foot
            var ballDiameter = 22; // in cm
            var soccerBall = new SoccerBall(ballDiameter);

            // action
            var pyramid = PyramidFactory.Build(pyramidHigh, soccerBall);

            // assert
            Assert.AreEqual(220, pyramid.NumberOfUsedBalls, "Number of used balls is not correct!");
        }
    }
}