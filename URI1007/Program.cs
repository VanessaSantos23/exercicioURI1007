using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1007
{
    public class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, dif;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            dif = A * B - C * D;

            Console.WriteLine("DIFERENÇA = " + dif);

            Console.ReadLine();
        }
    }
}
