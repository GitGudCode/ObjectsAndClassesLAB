using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
            var point = ReadArrayOfPoints();
        }
       

        private static Point[] ReadArrayOfPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (int i = 0; i < n - 1; i++)
            {
                points[i] = Point.
            }

        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        static  Point ReadPoint()
        {
            var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = new Point() { X = coords[0], Y = coords[1] };
            return p;
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


