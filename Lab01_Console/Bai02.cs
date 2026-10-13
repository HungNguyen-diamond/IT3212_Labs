using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai02
    {
        public static void ThucHien()
        {
            Console.WriteLine("Bài 2");
            Console.Write("Nhập bán kính r = ");
            if(!double.TryParse(Console.ReadLine(), out double r)|| r <= 0)
            {
                Console.WriteLine("Bán kính phải lớn hơn 0");
                return;
            }

            Console.Write("Nhập chiều cao h = ");
            if(!double.TryParse(Console.ReadLine(), out double h)|| h<= 0)
            {
                Console.WriteLine("Chiều cao phải lớn hơn 0");
                return;
            }

            double Sxq = 2 * Math.PI * r * h;
            double V = Math.PI * r * r * h;
            Console.WriteLine("Diện tích xung quanh là: {0:N2}", Sxq);
            Console.WriteLine("Thể tích là: {0:N2}", V);
        }
    }
}
