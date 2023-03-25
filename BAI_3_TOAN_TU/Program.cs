using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_TOAN_TU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //Nhập xuất thông tin máy tính
            /* ma: string 
             * hang: string 
             * gia: double
             * inch: float
             * win: int
             * isNew: bool => true/false
             */
            //Nhập
            Console.Write("Nhập mã máy: ");
            string ma = Console.ReadLine();
            Console.Write("Nhập hãng: ");
            string hang = Console.ReadLine();
            Console.Write("Nhập giá: ");
            double gia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập inch: ");
            float inch = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập win: ");
            int win = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập mới-true , cũ-false: ");
            bool isNew = Convert.ToBoolean(Console.ReadLine());
            //xuất
            Console.WriteLine($"Mã máy: {ma}");
            Console.WriteLine($"Hãng máy: {hang}");
            Console.WriteLine($"Giá: {gia}");
            Console.WriteLine($"Màn hình: {inch} inch");
            Console.WriteLine($"Win: {win}");
            Console.WriteLine($"Máy mới: {isNew}");
            Console.WriteLine($"{(isNew == true ? "Máy mới" : "Máy cũ")}");

            //bool -> true
            //if (isNew)
            //{
            //    Console.WriteLine("Máy mới");
            //}
            //else { Console.WriteLine("Máy cũ"); }
        }
    }
}
