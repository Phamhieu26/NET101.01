using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPBAI10_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //ctor ko tham số
            MayTinh mtDell = new MayTinh();
            MayTinh mtHP = new MayTinh();
            //ctor có tham số
            MayTinh mtAsus = new MayTinh(3,"Asus",2020,14.3,true);
            MayTinh mtLG = new MayTinh(4,"LG",2017,16.5,false);

            //gán gtri 
            mtDell.Id = 1;
            mtDell.Hang = "Dell";
            mtDell.NamSX = 2021;
            mtDell.Inch = 15;
            mtDell.IsNew = true;
            ///
            mtHP.Id = 2;
            mtHP.Hang = "HP";
            mtHP.NamSX = 2020;
            mtHP.Inch = 16.5;
            mtHP.IsNew = false;

            //In thong tin
            mtDell.InThongTin();
            mtHP.InThongTin();
            mtAsus.InThongTin();
            mtLG.InThongTin();
        }
    }
}
