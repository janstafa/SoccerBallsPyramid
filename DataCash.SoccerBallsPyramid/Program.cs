using System;
using DataCash.SoccerBallsPyramid.Factory;
using DataCash.SoccerBallsPyramid.Model;

namespace DataCash.SoccerBallsPyramid
{
   internal class Program
    {
        static void Main()
        {
            Run();
        }

       internal static void Run()
       {
           try
           { 
               Console.WriteLine("Pyramid high [foot]: ");
               var pyramidHigh = double.Parse(Console.ReadLine());

               Console.WriteLine("Soccer ball diameter [cm]: ");
               var soccerBallDiameter = double.Parse(Console.ReadLine());

               var soccerBall = new SoccerBall(soccerBallDiameter);

               var pyramid = PyramidFactory.Build(pyramidHigh, soccerBall);

               Console.WriteLine("The pyramid was created from {0} soccer balls.", pyramid.NumberOfUsedBalls);
           }
           catch (FormatException formatException)
           {
               Console.WriteLine(formatException.Message);
           }
           finally
           {
               Console.WriteLine("Press any key to exit...");
               Console.ReadLine();
           }
       }
    }
}
