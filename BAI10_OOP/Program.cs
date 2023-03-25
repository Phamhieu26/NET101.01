using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI10_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //1. Khởi tạo đối tượng
            //1.1 khởi tạo đối tượng = constructor ko tham số
            SinhVien svPoly = new SinhVien();
            //1.2 constructor có tham số
            SinhVien svBtec = new SinhVien("BT1","Mai Anh",2004,9,false);
            SinhVien svNEU = new SinhVien("NEU1","Hoàng",2005,7,true);
            //2. gán giá trị bằng properties (set)
            svPoly.Msv = "PH1";
            svPoly.HoTen = "Tuấn Anh";
            svPoly.NamSinh = 2002;
            svPoly.Diem = 8.5;
            svPoly.IsNam = true;
            /////
            svNEU.NamSinh = 2003;
            //3.Truy xuất: lấy giá trị
            Console.WriteLine($"Xin chao {svPoly.HoTen}");
            //4. gọi phương thức inthongtin()
            svPoly.InThongTin();
            svNEU.InThongTin();
            svBtec.InThongTin();
            //Bai tap
            /* Tao class may tinh gom cac thuoc tinh
             * - id: int
             * - hnang: string
             * - namSX: int
             * - inch: double
             * - isNew: bool
             * => private tất cả các thuộc tính
             * tạo constructor ko tham số, có tham số
             * có đầy đủ properties, tạo phương thức Inthongtin()
             * => sang main(): tạo 2 dtuong = ctor ko tham so va 2 dtuong = ctor có tham số
             * sau do in thong tin bang phuong thuc inthongtin()
             */
        }
    }
}
