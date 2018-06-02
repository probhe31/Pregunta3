using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Combinations combinations = new Combinations();
            int n = 5;
            Console.WriteLine("Ladder's steps: " + n);
            Console.WriteLine("Step Combinations: " + combinations.CountCombinations(n,0));

            Console.ReadKey();
        }
    }
}
