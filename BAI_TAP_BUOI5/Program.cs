using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_BUOI5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*Bài 1: Nhập và xuất thông tin Xe Máy
            * -id: int
            * -hang: string
            * -gia: double
            * -phanKhoi: int
            * -isVietNam: bool
            * => yêu cầu in ra true là Xe Máy Việt Nam / false là Xe Máy Nước Ngoài
            */
            Console.Write("Nhập id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập hãng: ");
            string hang = Console.ReadLine();
            Console.Write("Nhập giá: ");
            double gia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập phân khối: ");
            int phanKhoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Xuất xứ Việt Nam-true / Nước ngoài-false: ");
            bool isVietNam = Convert.ToBoolean(Console.ReadLine());
            // Xuất thông tin:
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Hãng: {hang}");
            Console.WriteLine($"Giá: {gia}");
            Console.WriteLine($"Phân khối: {phanKhoi}");
            if (isVietNam)
            {
                Console.WriteLine("Xe máy Việt Nam");
            }
            else
            {
                Console.WriteLine("Xe máy nước ngoài");
            }


            /*
            * Bài 2: Nhập min-max(int) từ bàn phím
            * -Nếu người dùng nhập min/ max < 0 yêu cầu nhập lại
            *-In ra tất cả các số lẻ trong khoảng min - max
            * -và đếm xem có bao nhiêu số lẻ đó
            */
            Console.WriteLine("Nhập Min: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập max: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int dem = 0;
            if (min <0 || max < 0)
            {
                Console.WriteLine("Nhập sai, nhập lại!");
            }
            else
            {
                for ( int i = min; i <= max; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine($"{i}");
                        dem++;
                    }
                }
                Console.WriteLine($"Có {dem} số lẻ trong khoảng min max");
            }
        }
    }
}
