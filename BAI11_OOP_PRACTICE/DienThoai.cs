using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI11_OOP_PRACTICE
{
    internal class DienThoai
    {
        //1. thuộc tính
        private string seri;
        private string hang;
        private int namSX;
        private int dungLuong;
        private bool isNew; //true-mới , false-cũ
        //2. tạo ctor
        //2.1 ctor ko tham số
        public DienThoai()
        {
            Console.WriteLine("Đây là điện thoại");
        }
        //2.2 ctor có tham số
        public DienThoai(string seri, string hang, int namSX, int dungLuong, bool isNew)
        {
            this.seri = seri;
            this.hang = hang;
            this.namSX = namSX;
            this.dungLuong = dungLuong;
            this.isNew = isNew;
        }

        //3. properties
        public string Seri { get => seri; set => seri = value; }
        public string Hang { get => hang; set => hang = value; }
        public int NamSX { get => namSX; set => namSX = value; }
        public int DungLuong { get => dungLuong; set => dungLuong = value; }
        public bool IsNew { get => isNew; set => isNew = value; }

        //4. inthongtin()
        public void InThongTin()
        {
            Console.WriteLine($"Điện thoại: " +
                $"Seri: {seri} | " +
                $"Hãng: {hang} | " +
                $"Năm sản xuất: {namSX} | " +
                $"Dung lượng: {dungLuong} | " +
                $"isNew: {(isNew == true ? "Mới" : "Cũ")} | " +
                $"isNew: {GetTinhTrang()}");
        }
        public string GetTinhTrang()
        {
            if (isNew)
            {
                return "Mới";
            }
            else
            {
                return "Cũ";
            }
        }
    }
}
