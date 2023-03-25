using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI10_OOP
{
    internal class SinhVien
    {
        //1. Tạo thuộc tính
        //Phải private tất cả các thuộc tính
        private string msv;
        private string hoTen;
        private int namSinh;
        private double diem;
        private bool isNam; //true-nam false-nữ

        //2. constructor- hàm tạo
        //2.1 constructor ko tham số
        //ctor tab
        public SinhVien()
        {

        }
        //2.2 constructor có tham số
        // bôi đen tất cả thuộc tính -> chuột phải , quick action -> generate constructor

        public SinhVien(string msv, string hoTen, int namSinh, double diem, bool isNam)
        {
            this.msv = msv;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.diem = diem;
            this.isNam = isNam;
        }

        //3. properties
        // Vì thuộc tính private  =>  cần properties (get; set)
        //=> để có thể get lấy ra và set gán lại
        //bôi đen thuộc tính -> quick action -> encapsulate field...
        public string Msv { get => msv; set => msv = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }
        public bool IsNam { get => isNam; set => isNam = value; }
        
        //4. In thông tin
        public void InThongTin()
        {
            Console.WriteLine($"SinhVien: msv= {msv};" +
                $"hoTen= {hoTen};" +
                $"namSinh= {namSinh};" +
                $"diem= {diem};" +
                $"isNam= {isNam}");
        }

    }
}
