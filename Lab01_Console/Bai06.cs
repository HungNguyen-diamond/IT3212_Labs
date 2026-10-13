using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai06
    {
        public static void ThucHien()
        {
            Console.WriteLine("Bài 6");
            Console.Write("a = "); double.TryParse(Console.ReadLine(), out double a);
            Console.Write("b = "); double.TryParse(Console.ReadLine(), out double b);
            Console.Write("c = "); double.TryParse(Console.ReadLine(), out double c);

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine(c == 0 ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.");
                else
                    Console.WriteLine("Nghiệm x = {0:F2}", -c / b);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Phương trình vô nghiệm.");
                else if (delta == 0)
                    Console.WriteLine("Nghiệm kép x1 = x2 = {0:F2}", -b / (2 * a));
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1 = {0:F2}, x2 = {1:F2}", x1, x2);
                }
            }
        }
    }
}
