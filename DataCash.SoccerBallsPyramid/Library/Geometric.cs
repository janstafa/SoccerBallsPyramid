﻿using System;

namespace DataCash.SoccerBallsPyramid.Library
{
    internal static class Geometric
    {
        /// <summary>
        /// Calculates length of A side of a regular tetrahedron.
        /// </summary>
        /// <param name="regularTetrahedronHigh">High of a regular tetrahedron in cm.</param>
        /// <returns>Calculated length of A side of a regular tetrahedron.</returns>
        internal static double CalculateLengthOfSideOfRegularTetrahedron(double regularTetrahedronHigh)
        {
            return regularTetrahedronHigh / (Math.Sqrt(6) / 3);
        }
    }
}