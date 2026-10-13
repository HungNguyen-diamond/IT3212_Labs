using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai03
    {
        public static void ThucHien()
        {
            Console.WriteLine("Bài 3");
            Console.Write("Nhập điểm 1-10: ");
            if(!double.TryParse(Console.ReadLine(), out double diem) || diem < 0 || diem > 10)
            {
                Console.WriteLine("Điểm không hợp lệ");
                return;
            }
            if (diem >= 9.0) Console.WriteLine("Xuất sắc");
            else if (diem >= 8.0) Console.WriteLine("Giỏi");
            else if (diem >= 6.5) Console.WriteLine("Khá");
            else if (diem >= 5.0) Console.WriteLine("Trung bình");
            else Console.WriteLine("Yếu");
        }
    }
}
