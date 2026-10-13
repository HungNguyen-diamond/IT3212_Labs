using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Bai09
    {
        public static void ThucHien()
        {
            Console.WriteLine("Bài 9");
            Console.Write("Nhập số từ 0-99: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0 || n > 99) return;

            string[] dv = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            if (n < 10)
            {
                Console.WriteLine(dv[n]);
                return;
            }

            int chuc = n / 10;
            int donVi = n % 10;
            string strChuc = (chuc == 1) ? "Mười" : $"{dv[chuc]} mươi";
            string strDonVi = "";

            if (donVi == 1 && chuc > 1) strDonVi = "mốt";
            else if (donVi == 4 && chuc > 1) strDonVi = "tư";
            else if (donVi == 5) strDonVi = "lăm";
            else if (donVi > 0) strDonVi = dv[donVi];

            Console.WriteLine("{0} {1}", strChuc, strDonVi.Trim());
        }
    }
}
