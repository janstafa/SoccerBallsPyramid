using System;
using SoccerBallsPyramid.Library;
using SoccerBallsPyramid.Model;

namespace SoccerBallsPyramid.Factory
{
    internal static class PyramidFactory
    {
        /// <summary>
        /// Compute the total number of all balls used to construct a pyramid.
        /// </summary>
        /// <param name="numberOfLevels">Number of pyramid levels.</param>
        /// <returns>Total number of used balls.</returns>
        internal static double GetTotalNumberOfBallsUsedInConstruction(double numberOfLevels)
        {
            //Sn =( n(n+1)(n+2)) /6;
            return (numberOfLevels * (numberOfLevels + 1) * (numberOfLevels + 2)) / 6;
        }

        /// <summary>
        /// Builds a pyramid from given high and soccer ball(s).
        /// </summary>
        /// <param name="pyramidHigh">Pyramid high in [cm].</param>
        /// <param name="soccerBall">Soccer ball.</param>
        /// <returns>Builded pyramid.</returns>
        internal static Pyramid Build(double pyramidHigh, SoccerBall soccerBall)
        {
            var pyramid = new Pyramid(pyramidHigh);

            var pyramidHighInCm = Conversion.FootToCentimeters(pyramid.High);

            var smallPyramidInsideBallsHigh = Geometrics.CalculateTetrahedronHigh(soccerBall.Diameter);

            //n = (ph + h - d)/h
            var numberOfPyramidLevels = Math.Round((pyramidHighInCm + smallPyramidInsideBallsHigh - soccerBall.Diameter) / smallPyramidInsideBallsHigh);

            pyramid.NumberOfUsedBalls = GetTotalNumberOfBallsUsedInConstruction(numberOfPyramidLevels);

            return pyramid;
        }
    }
}
