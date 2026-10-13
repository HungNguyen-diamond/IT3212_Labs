using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai08
    {
        public static void ThucHien()
        {
            Console.WriteLine("Bài 8");
            Console.Write("Nhập n = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 2) return;

            Console.WriteLine("Các số nguyên tố <= {0}:", n);
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i)) Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        private static bool IsPrime(int k)
        {
            if (k < 2) return false;
            for (int i = 2; i <= Math.Sqrt(k); i++)
                if (k % i == 0) return false;
            return true;
        }
    }
}
