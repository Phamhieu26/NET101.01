using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI11_OOP_PRACTICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //Khởi tạo dtg bằng ctor có tham số
            DienThoai dt1 = new DienThoai("DT1","Iphone",2012,32,false);
            //Khởi tạo dtg bằng ctor ko tham số
            DienThoai dt2 = new DienThoai();
            dt2.Seri = "DT2";
            dt2.Hang = "SamSung";
            dt2.NamSX = 2019;
            dt2.DungLuong = 16;
            dt2.IsNew = true;
            //In thông tin
            dt1.InThongTin();
            dt2.InThongTin();

            DienThoai dt3 = new DienThoai();
            //seri
            Console.WriteLine("Nhập seri: ");
            dt3.Seri = Console.ReadLine();
            //hang
            Console.WriteLine("Nhập hãng: ");
            dt3.Hang = Console.ReadLine();
            //nam sx
            Console.WriteLine("Nhập năm sản xuất: ");
            dt3.NamSX = Convert.ToInt32(Console.ReadLine());
            //dung luong
            Console.WriteLine("Nhập dung lượng: ");
            dt3.DungLuong = Convert.ToInt32(Console.ReadLine());
            //isnew
            Console.WriteLine("Mới hay cũ (true/false): ");
            dt3.IsNew = Convert.ToBoolean(Console.ReadLine());

            dt3.InThongTin();

        }
    }
}
