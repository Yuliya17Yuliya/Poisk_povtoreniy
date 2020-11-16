using System;

namespace Poisk_povtoreniy
{
    class Program
    {
        static void Main(string[] args)
        {
            int m; // содержимое смс
            int max = 0, idx=0;

            Console.WriteLine("Введите количество смс:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[17];

            for (int i=1; i<=n; i++)
            {
                Console.WriteLine("Введите номер пары:");
                m = Convert.ToInt32(Console.ReadLine());

                A[m]++;
            }

            Console.WriteLine();
            for (int i = 1; i <17; i++)
            {
                Console.WriteLine(A[i]);

                if (max < A[i])
                {
                    max = A[i];
                    idx = i;
                }
                    
            }

            Console.WriteLine();

            Array.Sort(A);
            for (int i = 16; i >= 1; i--)
                Console.WriteLine($"{A[i]}");

            Console.WriteLine($"Пара победитель: {idx}");

            Console.ReadKey();
        }
    }
}
