using System;

namespace ex._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create point
            Point p1 = new Point(10, 10);
            Point p2 = new Point(5, 7);
            Point p3 = new Point(2, 3);
            Point p4 = new Point(8, 12);
            Point p5 = new Point(1, 2);
            Point p6 = new Point(4, 5);

            Drawing d = new Drawing(10, 20);  // יצירת אובייקט Drawing עם 10 נקודות

            //add point to array
            d.AddPoint(p1);
            d.AddPoint(p2);
            d.AddPoint(p3);
            d.AddPoint(p4);
            d.AddPoint(p5);
            d.AddPoint(p6);

            Point n = d.GetPointN(5); 

            
            if (n != null)
            {
                Console.WriteLine($"the point in place 5 is {n}");
            }
            else
            {
                Console.WriteLine("No point in place 5");
            }

            //add a new line
            Line l = new Line(p1, p2);

            //add a new point
            Point newPoint = new Point(5, 7);

            d.AddPoint(newPoint);

            //counter the time that point found
            int count = d.PointInLines(newPoint);
            Console.WriteLine($"the point {newPoint} {count} times in the lines");

            //check if point find
            Console.WriteLine($"the point {newPoint} in any line?---{d.AnyPointInLine(newPoint)}");


        }
    }
}
