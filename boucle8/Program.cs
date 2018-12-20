using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boucle8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pairs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int counter;
            for(counter = 0 ; counter < pairs.Length; counter++)
            {
                if (pairs[counter] % 2 == 0) // % (se prononce modulo) donne le reste d'une division. Dans ce cas, la division par 2 d'un nombre avec 0 comme reste. Exemple qui ne fonctionne pas, 25/2 = 12 + 1(reste) 
                Console.WriteLine(pairs[counter]);
            }
        }
    }
}
