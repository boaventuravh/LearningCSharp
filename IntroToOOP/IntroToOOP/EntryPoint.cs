using PointsAndLines;
using System;
class EntryPoint
  {
      static void Main()
      {
            Point point = new Point(6,5);

            Point pointTwo = new Point();

            pointTwo.x = 10;
            pointTwo.y = 11;
            
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            Console.WriteLine(pointTwo.x + pointTwo.y);
      }
  }
        
