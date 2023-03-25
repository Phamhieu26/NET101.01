using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_CAU_TRUC_RE_NHANH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //1. vòng lặp for
            // for tab tab
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i= {i}; ");
            }
            Console.WriteLine("Nhập n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine($"i = {i}; ");
                }
            }
            //2. do while
            int a = 0;
            while (a<n)
            {
                Console.WriteLine($"{a}");
                a++;
            }
            int b = 0;
            while (b<10)
            {
                if (b == 5)
                {
                    Console.WriteLine("CH" + b);
                    //break;
                    b++;
                    continue;
                }
                Console.WriteLine("CH" +b);
                b++;
            }

            //do while
            int c = 0;
            do
            {
                Console.WriteLine("CH");
                c++;
            } while (c<20);
        }
    }
}
