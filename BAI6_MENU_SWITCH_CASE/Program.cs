using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI6_MENU_SWITCH_CASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            int chon;
            do
            {
                Console.WriteLine("-----------Menu---------");
                Console.WriteLine("--------1. Bai 1--------");
                Console.WriteLine("--------2. Bai 2--------");
                Console.WriteLine("--------3. Bai 3--------");
                Console.WriteLine("--------0. Thoat--------");
                Console.WriteLine("------------------------");
                Console.WriteLine("Chon chuc nang");
                chon = Convert.ToInt32(Console.ReadLine());
                // sw tab
                switch (chon)
                {
                    case 1:
                        //do sthg
                        Console.WriteLine("--------1. Bai 1--------");
                        break;
                    case 2:
                        //do sthg
                        Console.WriteLine("--------2. Bai 2--------");
                        break;
                    case 3:
                        //do sthg
                        Console.WriteLine("--------3. Bai 3--------");
                        break;
                    case 0:
                        Console.WriteLine("Thoat chuong trinh");
                        Environment.Exit(0); //thoat ctr
                        break;
                    default:
                        Console.WriteLine("Chon lai!!!");
                        break;
                }
            } while (chon != 0);
        }
    }
}
