/*
* Programa C# para imprimir números ímpares em um determinado intervalo
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NumerosImparesIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numerosImpares = Enumerable.Range(20, 20).Where(x => x % 2 != 0);

            foreach (var num in numerosImpares)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}