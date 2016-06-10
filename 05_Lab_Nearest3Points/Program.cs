using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class NearestThreePoints
    {
        static void Main(string[] args)
        {
            var points = Point.ReadArrayOfPoints();
            var nearestPoint = FindNearestPoints(points);

            Console.WriteLine($"{Point.CalcDistance(nearestPoint[0], nearestPoint[1])}:f3");
            Console.WriteLine(nearestPoint[0]);
            Console.WriteLine(nearestPoint[1]);
        }

        public static Point[] FindNearestPoints(Point[] points)
        {
            var minDistance = double.MaxValue; // Bezkrainost e nachalna tochka
            var nearestPoints = new Point[] {};
            for (int first = 0; first < points.Length; first++)
            {
                for (int second = first+1; second < points.Length; second++)
                {
                    var p1 = points[first];
                    var p2 = points[second];
                    var dist = Point.CalcDistance(p1, p2);
                    if (dist < minDistance)
                    {
                        minDistance = dist;
                        nearestPoints = new Point[] {p1, p2};
                    }
                }
                
            }
            return nearestPoints;

        }


        internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Point ReadPoint()
        {
            var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = new Point() { X = coords[0], Y = coords[1] };
            return p;
        }
        public static Point[] ReadArrayOfPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (int i = 0; i < n - 1; i++)
            {
                points[i] = Point.ReadPoint();
            }
            return points;
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            var a = p1.X - p2.X;
            var b = p1.Y - p2.Y;
            var sum = a * a + b * b;
            var distance = Math.Sqrt(sum);
            return distance;
        }
    }
}
    


