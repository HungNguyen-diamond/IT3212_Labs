using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai05
    {
        public static void ThucHien()
        {
            Console.WriteLine("Bài 5");
            try
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("a / b = {0}", a / b);
            }
            catch (FormatException)
            {
                Console.WriteLine("Dữ liệu không phải số nguyên");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Không thể chia cho 0");
            }
            finally
            {
                Console.WriteLine("Kết thúc phép tính");
            }
        }
    }
}
