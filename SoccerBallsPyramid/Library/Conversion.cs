namespace SoccerBallsPyramid.Library
{
    internal static class Conversion
    {
        /// <summary>
        /// Converts foot to cm.
        /// </summary>
        /// <param name="foot">Lenght in foot</param>
        /// <returns>Corresponding lenght in cm.</returns>
        internal static double FootToCentimeters(double foot)
        {
            return foot * 30.48;
        }
    }
}