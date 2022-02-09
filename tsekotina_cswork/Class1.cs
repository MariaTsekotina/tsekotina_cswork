using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsekotina_cswork
{
    class kordused_Massiivid
    {

        static void Main(string[] args)
        {
            char[] Tahed = new char[7] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            Console.WriteLine($"Esimene täht on {Tahed[0]}");

            foreach (var taht in Tahed)
            {
                Console.Write($"{taht,}");
            }

            Random md = new Random();
            int[] arvud = new int[10];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = md.Next(5, 500);
            }

            foreach (int arv in arvud)
            {
                Console.Write($"{arv,4}");
            }
            int[,] tabel = new int[20, 10];
            for (int i = 1; i < 21; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"rida {i} koht{j}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
