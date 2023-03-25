using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPBAI10_OOP
{
    internal class MayTinh
    {
        //1.Tạo thuộc tính:
        private int id;
        private string hang;
        private int namSX;
        private double inch;
        private bool isNew; //True-moi , false-cu
        //2. Tạo constructor
        //không tham số:
        public MayTinh()
        {

        }

        //có tham số:
        public MayTinh(int id, string hang, int namSX, double inch, bool isNew)
        {
            this.id = id;
            this.hang = hang;
            this.namSX = namSX;
            this.inch = inch;
            this.isNew = isNew;
        }

        //3. properties
        public int Id { get => id; set => id = value; }
        public string Hang { get => hang; set => hang = value; }
        public int NamSX { get => namSX; set => namSX = value; }
        public double Inch { get => inch; set => inch = value; }
        public bool IsNew { get => isNew; set => isNew = value; }

        //4. Tạo phương thức inthongtin()
        public void InThongTin()
        {
            Console.WriteLine($"Máy tính: id = {id}; hang = {hang}; namSX = {namSX}; inch = {inch}; mới/cũ = {(isNew == true ? "Máy mới" : "Máy cũ")}");
        }
    }
}
