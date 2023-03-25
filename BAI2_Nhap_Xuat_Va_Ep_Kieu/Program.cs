using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI2_Nhap_Xuat_Va_Ep_Kieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. ép kiểu giữa các số
            //ép kiểu ngầm định to->nhỏ
            int a = 10;
            double b = a;
            Console.WriteLine($"b={b}");
            //ép kiểu tường minh nhỏ->to
            double c = 8.5;
            int d = (int)c;
            Console.WriteLine($"d={d}");

            //2. ép kiểu từ string về số
            string num1 = "2";
            string num2 = "6";
            Console.WriteLine(num1+num2);

            int n1= Convert.ToInt32(num1);
            int n2= Convert.ToInt32(num2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n1+n2);
        }
    }
}
