using System;

namespace SoccerBallsPyramid.Model
{
    internal class SoccerBall
    {
        public double Diameter { get; private set; }

        public SoccerBall(double diameter)
        {
            #region Defensive area

            if (diameter <= 0)
            {
                throw new ArgumentOutOfRangeException("diameter", "SoccerBall must have none zero or none negative diameter.");
            }

            #endregion

            Diameter = diameter;
        }
    }
}
