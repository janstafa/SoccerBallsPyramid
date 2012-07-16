using System;

namespace DataCash.SoccerBallsPyramid.Model
{
    internal class Pyramid
    {
        /// <summary>
        /// High of a pyramid in foot.
        /// </summary>
        public double High { get; private set; }

        /// <summary>
        /// Total number of used balls to build a pyramid.
        /// </summary>
        public double NumberOfUsedBalls { get; set; }

        public Pyramid(double high)
        {
            #region Defensive area

            if (high <= 0)
            {
                throw new ArgumentOutOfRangeException("heigh", "Pyramid must have none zero or none negative heigh.");
            }

            #endregion

            High = high;
        }
    }
}