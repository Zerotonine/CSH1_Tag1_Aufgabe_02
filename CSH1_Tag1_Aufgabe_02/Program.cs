using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag1_Aufgabe_02
{
    class Program
    {
        static ushort i = 5;
        static float f = 1.1f;
        static char c = 'x';

        static void Ausgabe()
        {
            string s = "";

            for(int j = 0; j < i; j++)
            {
                s += c.ToString() + f;
            }
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            Ausgabe();
            Console.ReadKey();
        }
    }
}
