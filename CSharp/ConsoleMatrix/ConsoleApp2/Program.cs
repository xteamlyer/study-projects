using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; int m = 0;

            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("m=");
            m = Convert.ToInt32(Console.ReadLine());

            int[,] mas = new int[m, n];

            for(int j = 0; j < n; j++)
            {
                for(int i = 0; i < m; i++)
                {
                    mas[i, j] = 5 * j;
                }
            }
            for(int j = 0; j < m; j++)
            {
                for(int i = 0; i < n; i++)
                {
                    Console.Write(string.Format("{0,5:d}", mas[j, i]));
                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }
}
