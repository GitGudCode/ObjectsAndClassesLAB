using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _02_Lab_FactorialBig
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = ReadPoint();
            var p2 = ReadPoint();
            Console.WriteLine("{0:f3}", CalcDistane(p1, p2));
            


        }

        static Point ReadPoint()
        {
            var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = new Point() {X = coords[0], Y = coords[1]};
            return p;
        }

        static double CalcDistane(Point p1, Point p2)
        {
            var a = p1.X - p2.X;
            var b = p1.Y - p2.Y;
            var sum = a*a + b*b;
            var distance = Math.Sqrt(sum);
            return distance;
        }
    }

    class Point
    {
        public double X { get; set; }

        public double Y { get; set; }


    }

}
