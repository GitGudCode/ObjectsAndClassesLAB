using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _01_LabTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();
            for (int first = 0; first < words.Length; first++)
            {
                var second = rnd.Next(0, words.Length);
                var old = words[first];
                words[first] = words[second];
                words[second] = old;

            }
            Console.WriteLine(String.Join("\r\n", words));
        }
    }
}
