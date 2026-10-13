using System;

namespace Lab01_Console
{
    internal class Bai04
    {
        public static void ThucHien()
        {
            Console.WriteLine("Bài 4");
            int chon;
            do
            {
                Console.WriteLine("\n1. Tổng 1..n");
                Console.WriteLine("2. Bảng cửu chương");
                Console.WriteLine("0. Quay lại");
                Console.Write("Chọn: ");
                int.TryParse(Console.ReadLine(), out chon);

                switch (chon)
                {
                    case 1:
                        {
                            Console.Write("Nhập n = ");
                            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                            {
                                int tong = 0;
                                for (int i = 1; i <= n; i++) tong += i;
                                Console.WriteLine($"Tổng từ 1 đến {n} = {tong}");
                            }
                            else
                            {
                                Console.WriteLine("n phải là số nguyên dương.");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Nhập n = ");
                            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                            {
                                Console.WriteLine("BẢNG CỬU CHƯƠNG {0}",n);
                                for (int i = 1; i <= 10; i++)
                                {
                                 
                                    Console.WriteLine("{0} x {1} = {2}",n,i,n*i);
                                }
                            }
                            else
                            {
                                Console.WriteLine("n phải là số nguyên dương.");
                            }
                            break;
                        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
                }
            } while (chon != 0);
        }
    }
}