using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int choice;
            do
            {
                Console.Clear();
                Console.Write("Chọn bài từ 1-10: ");

                if (!int.TryParse(Console.ReadLine(), out choice)) choice = -1;

                Console.WriteLine("\n--------------------------------------------------");
                switch (choice)
                {
                    case 1: Bai01.ThucHien(); break;
                    case 2: Bai02.ThucHien(); break;
                    case 3: Bai03.ThucHien(); break;
                    case 4: Bai04.ThucHien(); break;
                    case 5: Bai05.ThucHien(); break;
                    case 6: Bai06.ThucHien(); break;
                    case 7: Bai07.ThucHien(); break;
                    case 8: Bai08.ThucHien(); break;
                    case 9: Bai09.ThucHien(); break;
                    case 10: Bai10.ThucHien(); break;
                    case 0: Console.WriteLine("Đã thoát chương trình."); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                }

            } while (choice != 0);
        }
    }
}
