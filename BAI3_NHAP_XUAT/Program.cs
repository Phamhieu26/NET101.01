using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_NHAP_XUAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //nhập xuất thông tin sinh viên 
            /* msv: string
             * hoTen: string
             * namSinh: int
             * diem: double
             * isBoy: bool
             */

            //console readline đọc 1 dòng dữ liệu từ bàn phím
            Console.WriteLine("Nhập mã sinh viên: ");
            string msv = Console.ReadLine();
            Console.WriteLine("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh: ");
            int namSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập điểm: ");
            double diem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Là nam - true, nữ-false");
            bool isBoy = Convert.ToBoolean(Console.ReadLine());

            //Phần 2 xuất 
            Console.WriteLine($"msv = {msv}");
            Console.WriteLine($"Họ Tên = {hoTen}");
            Console.WriteLine($"Tuổi = {2023-namSinh}");
            Console.WriteLine($"Điểm = {diem}");
            Console.WriteLine($"isBoy = {isBoy}");
        }
    }
}
