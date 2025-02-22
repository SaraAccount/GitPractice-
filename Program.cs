using System;

namespace ex._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // יצירת נקודות
            Point p1 = new Point(10, 10);
            Point p2 = new Point(5, 7);
            Point p3 = new Point(2, 3);
            Point p4 = new Point(8, 12);
            Point p5 = new Point(1, 2);
            Point p6 = new Point(4, 5);

            Drawing d = new Drawing(10, 20);  // יצירת אובייקט Drawing עם 10 נקודות

            // הוספת נקודות למערך
            d.AddPoint(p1);
            d.AddPoint(p2);
            d.AddPoint(p3);
            d.AddPoint(p4);
            d.AddPoint(p5);
            d.AddPoint(p6);

            // עכשיו, תוכל לגשת לנקודה במקום 5 (האינדקסים מתחילים מ-0)
            Point n = d.GetPointN(5);  // מקבל את הנקודה במקום ה-5

            // הדפסת הנקודה (אם היא לא null)
            if (n != null)
            {
                Console.WriteLine($"the point in place 5 is {n}");
            }
            else
            {
                Console.WriteLine("No point in place 5");
            }

            // יצירת קו בין נקודות
            Line l = new Line(p1, p2);
            // יצירת נקודה חדשה
            Point newPoint = new Point(5, 7);

            // הוספת הנקודה החדשה
            d.AddPoint(newPoint);

            // ספירת מספר הפעמים שהנקודה נמצאת בקווים
            int count = d.PointInLines(newPoint);
            Console.WriteLine($"the point {newPoint} {count} times in the lines");

            // בדיקה אם הנקודה קיימת באחד הקווים
            Console.WriteLine($"the point {newPoint} in any line?---{d.AnyPointInLine(newPoint)}");
            Console.WriteLine("Shavuha Tov every body gool luck");

        }
    }
}
