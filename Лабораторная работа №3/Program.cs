using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массив
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите колличество элементов массива:");
            n = int.Parse(Console.ReadLine());
            int[] M = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                M[i] = rnd.Next(-100, 100);

            Print(M);

            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(" {0}", M[n]);
            }
            int[] T = new int[];

            int j = 0;
            for (int i = 0; i < n; i++)
                if (M[i] % 2 == 0)
                {
                    T[j] = M[i];
                    j++;
                }
            M = T;

            Print(M);
            int k;
            Console.Write("Введите колличество добавляемых элементов:");
            k = int.Parse(Console.ReadLine());
            T = new int[M.Length + k];


            for (int i = M.Length; i < T.Length; i++)
                T[i] = rnd.Next(-100, 100);

            M.CopyTo(T, 0);

            M = T;
            int l = 0, m = M.Length-1, tmp;

            while (l != m)
                if (M[l] < 0)
                {
                    tmp = M[m];
                    M[m] = M[l];
                    M[l] = tmp;
                    m--;
                }
                else
                    l++;

         }

        static void Print(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Item[{1}]={0} ", A[i], i);
            }
            Console.WriteLine();

        }
    }
}
