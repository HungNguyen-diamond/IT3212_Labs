using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai01
    {
        public static void ThucHien()
        {
            Console.WriteLine("Bài 1");
            string name;
            Console.Write("Họ và tên: ");
            name = Console.ReadLine();
            Console.WriteLine("Tên của bạn là: {0}", name);
            int namsinh;
            Console.Write("Nhập năm sinh: ");
            if (!int.TryParse(Console.ReadLine(), out namsinh))
            {
                Console.WriteLine("Năm sinh không hợp lệ.");
                return;
            }
            int tuoi = DateTime.Now.Year - namsinh;

            Console.WriteLine("Tuổi của bạn là: {0}", tuoi);
        }
    }
}
