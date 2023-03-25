using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI9_HAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. hàm không trả về 
             * 1-1: hàm ko trả về ko tham số
             * 1-2: hàm ko trả về có tham số
             * 2: hàm có trả về
             * 2-1: hàm có trả về ko tham số
             * 2-2: hàm có trả về có tham số
             */
            GetTuoi();
            Console.WriteLine("Nhập năm sinh: ");
            int namSinh = Convert.ToInt32(Console.ReadLine());
            GetTuoi(namSinh);
            int tuoi = TinhTuoi();
            Console.WriteLine($"Tuoi = {tuoi}");
            int tuoi2 = TinhTuoi(namSinh);
            Console.WriteLine($"Tuoi = {tuoi2}");
        }
        static void GetTuoi()
        {
            Console.WriteLine("Nhập tuổi: ");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tuổi của bạn là: {tuoi}");
        }

        static void GetTuoi(int namSinh)
        {
            int tuoi = 2023 - namSinh;
            Console.WriteLine($"Tuổi = {tuoi}");
        }

        static int TinhTuoi()
        {
            Console.WriteLine("Nhap nam sinh: ");
            int namSinh = Convert.ToInt32(Console.ReadLine());
            int tuoi = 2023 - namSinh;
            return tuoi;
        }
        
        static int TinhTuoi(int namSinh)
        {
            int tuoi = 2023 - namSinh;
            return tuoi;
        }
    }
}
