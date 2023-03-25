using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_MANG_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //1. Nhập và xuất 1 mảng số lượng bàn học trong từng phòng học toà L
            Console.WriteLine("------------ Nhập -----------");
            int n;
            do
            {
                Console.Write("Nhập số phòng toà L: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Nhập số phòng > 0!!!!");
                }
            } while (n <= 0);
            
            //Khởi tạo mảng số bàn học có kích thước = n phần tử
            int[] arrSoBan = new int[n];

            for (int i = 0; i < arrSoBan.Length; i++)
            {
                Console.Write($"Phòng L20{i+1} có số bàn là: ");
                arrSoBan[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("------------ Xuất -----------");
            Console.WriteLine("Cách 1: for i ");
            for (int i = 0; i < arrSoBan.Length; i++)
            {
                Console.WriteLine($"Số bàn phòng L20{i + 1} là: {arrSoBan[i]}");
            }
            Console.ReadKey();
        }
    }
}
