using System;
using SoccerBallsPyramid.Library;
using SoccerBallsPyramid.Model;

namespace SoccerBallsPyramid.Factory
{
    internal static class PyramidFactory
    {
        /// <summary>
        /// Count how many balls is needed to fill one floor of a pyramid from given number of balls on one side.
        /// </summary>
        /// <param name="startNumberOfBalls">Number of balls used as base.</param>
        /// <returns>Total number of used balls.</returns>
        internal static double GetNumberOfUsedBallsToBuildFloor(double startNumberOfBalls)
        {
            //computing the sum of all numbers from startNumberOfBalls to 1 using ∑(F,L)= ( L² - F² + F + L)/2 formula.
            var result = ((Math.Pow(startNumberOfBalls, 2) - 1) + startNumberOfBalls + 1) / 2;
            return result;
        }

        /// <summary>
        /// Compute the total number of all balls used to construct a pyramid.
        /// </summary>
        /// <param name="startNumberOfBalls">Number of balls used to build one (base) floor of a pyramid</param>
        /// <returns>Total number of used balls.</returns>
        internal static double GetTotalNumberOfBallsUsedInConstruction(double startNumberOfBalls)
        {
            double result = 0;

            var start = Math.Round(startNumberOfBalls);

            for (double i = start; i > 0; i--)
            {
                result += GetNumberOfUsedBallsToBuildFloor(i);
            }

            return result;
        }


        /// <summary>
        /// Counts start number of balls from ball diameter and length of side.
        /// </summary>
        /// <param name="sideLength">Side length.</param>
        /// <param name="ballDiameter">Ball diameter.</param>
        /// <returns></returns>
        internal static double GetStartBallNumber(double sideLength, double ballDiameter)
        {
            return sideLength / ballDiameter;
        }


        /// <summary>
        /// Builds a pyramid from given high and soccer ball(s).
        /// </summary>
        /// <param name="pyramidHigh">Pyramid high in [cm].</param>
        /// <param name="soccerBall">Soccer ball.</param>
        /// <returns></returns>
        internal static Pyramid Build(double pyramidHigh, SoccerBall soccerBall)
        {
            var pyramid = new Pyramid(pyramidHigh);

            var pyramidHighInCm = Conversion.FootToCentimeters(pyramid.High);

            var smallPyramidInsideBallsHigh = Geometric.CalculateTetrahedronHigh(soccerBall.Diameter);

            var numberOfPyramidLevels = ((pyramidHighInCm - soccerBall.Diameter) / (smallPyramidInsideBallsHigh * 2)) * 3;

            pyramid.NumberOfUsedBalls = GetTotalNumberOfBallsUsedInConstruction(numberOfPyramidLevels);

            return pyramid;
        }
    }
}
