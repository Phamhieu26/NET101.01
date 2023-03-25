using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI1_Khai_Bao_Bien
{
    internal class Program
    {
        static int _namSinh = 2001;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            // UTF8/Unicode nhập xuất tiếng việt
            int a;
            int b = 10;
            float canNang = 40.5f;
            double chieuCao = 170.5;

            char c = 'H';
            //char[] hoTen;
            string hoTen = "Phạm Hiếu";
            //camelCase hoTen _ đặt tên biến
            //PascalCase HoTen _ đặt tên class
            bool isBoy = false; //true/false

            var v1 = 10;
            var v2 = true;
            var v3 = "HN";
            //var nhận các kiểu dữ liệu nhưng phải khai báo giá trị
            Console.WriteLine(hoTen); // in ra màn hình
            Console.WriteLine("Tôi là: "+ hoTen);
            Console.WriteLine($"Tôi là {hoTen} cao {chieuCao}");
            Console.WriteLine($"Tuổi của tôi là {2023-_namSinh}");

            /* Biến toàn cục _tenBien dùng cho nhiều phương thức
             * biến cục bộ cho 1 phương thức
             */


        }
    }
}
