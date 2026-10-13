using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai07
    {
        public static void ThucHien()
        {
            Console.WriteLine("Bài 7");
            Console.Write("Nhập số lượng n = ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) return;

            int[] arr = new int[n];
            long tong = 0;
            int demChan = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử [{0}]: ", i + 1);
                int.TryParse(Console.ReadLine(), out arr[i]);
                tong += arr[i];
                if (arr[i] % 2 == 0) demChan++;
            }

            int max = arr[0], min = arr[0];
            foreach (var val in arr)
            {
                if (val > max) max = val;
                if (val < min) min = val;
            }

            Console.WriteLine("Tổng: {0}", tong);
            Console.WriteLine("Trung bình: {0:F2}", (double)tong / n);
            Console.WriteLine("Max: {0}, Min: {1}", max, min);
            Console.WriteLine("Số lượng số chẵn: {0}", demChan);
        }
    }
}
