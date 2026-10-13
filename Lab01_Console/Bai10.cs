using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai10
    {
        public static void ThucHien()
        {
            Console.WriteLine("Bài 10");
            Console.WriteLine("1. Tam giác vuông đặc\n2. Tam giác vuông rỗng\n3. Hình vuông rỗng");
            Console.Write("Chọn hình: ");
            int.TryParse(Console.ReadLine(), out int chon);
            Console.Write("Kích thước h = ");
            int.TryParse(Console.ReadLine(), out int h);

            if (h <= 1) return;

            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= (chon == 3 ? h : i); j++)
                {
                    if (chon == 1) Console.Write("* ");
                    else if (chon == 2) Console.Write((j == 1 || j == i || i == h) ? "* " : "  ");
                    else if (chon == 3) Console.Write((i == 1 || i == h || j == 1 || j == h) ? "* " : " ");
                }
                Console.WriteLine();
            }
        }
    }
}
