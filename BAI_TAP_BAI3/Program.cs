using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_BAI3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
            * BTVN:
            * Nhập và xuất thông tin món quà 8/3 bạn tặng cho NY
            * ten: string
            * giaTien: double
            * soLuong: int
            * isNew: bool //true- mới, false- cũ
            * noiMua: string
            */

            //Nhập liệu
            Console.WriteLine("Nhập tên quà: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhập giá tiền: ");
            double giaTien = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số lượng: ");
            int soLuong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Là mới-true hay cũ-false");
            bool isNew = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Nhập nơi mua: ");
            string noiMua = Console.ReadLine();

            //Xuất
            Console.WriteLine($"Tên quà: {ten}");
            Console.WriteLine($"Giá tiền: {giaTien}");
            Console.WriteLine($"Số lượng: {soLuong}");
            Console.WriteLine($"Là mới: {isNew}");
            Console.WriteLine($"Nơi mua: {noiMua}");

        }
    }
}
