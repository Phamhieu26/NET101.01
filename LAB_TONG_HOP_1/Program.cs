using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TONG_HOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            menu();
        }

        //Menu
        static void menu()
        {
            int chon;
            do
            {
                Console.WriteLine();
                Console.WriteLine("+-------------------MENU----------------------+");
                Console.WriteLine("1. Kiểm tra số chẵn lẻ");
                Console.WriteLine("2. Kiểm tra ngày tháng");
                Console.WriteLine("3. Mảng điểm ");
                Console.WriteLine("4. Mảng thông tin sinh viên Poly");
                Console.WriteLine("0. Kết thúc");
                Console.WriteLine("+---------------------------------------------+");
                Console.WriteLine("Chọn chức năng");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("--------1. Bai 1--------");
                        KiemTraSoChanLe();
                        break;
                    case 2:
                        Console.WriteLine("--------2. Bai 2--------");
                        KiemTraNgayThang();
                        break;
                    case 3:
                        Console.WriteLine("--------3. Bai 3--------");
                        XuLyMangDiem();
                        break;
                    case 4:
                        Console.WriteLine("--------3. Bai 4--------");
                        XuLyMangThongTin();
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Chọn lại!!!!");
                        break;
                }
            } while (chon != 0);
        }


        //Bài 1:
        static void KiemTraSoChanLe()
        {
            int count;
            do
            {
                Console.WriteLine("Nhập count: ");
                count = Convert.ToInt32(Console.ReadLine());
                if (count < 0)
                {
                    Console.WriteLine("Nhập số đếm lớn hơn 0!");
                }
            } while (count <= 0);

            int[] arrDaySo = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Nhập số thứ {i + 1}: ");
                arrDaySo[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Số chẵn: ");
            foreach (var so in arrDaySo)
            {
                if (so % 2 == 0)
                {
                    Console.Write($" {so} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Số lẻ: ");
            foreach (var so in arrDaySo)
            {
                if (so % 2 != 0)
                {
                    Console.Write($" {so} ");
                }
            }
        }


        //Bài 2:
        static void KiemTraNgayThang()
        {
            Console.Write("Nhập ngày hiện tại: ");
            int ngay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tháng hiện tại: ");
            int thang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập năm hiện tại: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (ngay > 31 || ngay < 1)
                    {
                        Console.WriteLine("Nhập sai ngày!!!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tháng có 31 ngày.");
                        //In ra ngày hôm sau
                        if (ngay == 31)
                        {
                            if (thang == 12)
                            {
                                Console.WriteLine($"Ngày hôm sau là: 1/1/{nam + 1}");
                            }
                            else
                            {
                                Console.WriteLine($"Ngày hôm sau là: 1/{thang + 1}/{nam}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Ngày hôm sau là: {ngay + 1}/{thang}/{nam}");
                        }
                        //In ra ngày hôm trước
                        if (ngay == 1)
                        {
                            if (thang == 1)
                            {
                                Console.WriteLine($"Ngày hôm trước là: 31/12/{nam - 1}");
                            }
                            else if (thang == 3)
                            {
                                if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                                {
                                    Console.WriteLine($"Ngày hôm trước là: 29/2/{nam}");
                                }
                                else
                                {
                                    Console.WriteLine($"Ngày hôm trước là: 28/2/{nam}");
                                }
                            }
                            else if (thang == 8)
                            {
                                Console.WriteLine($"Ngày hôm trước là: 31/7/{nam}");
                            }
                            else
                            {
                                Console.WriteLine($"Ngày hôm trước là: 30/{thang - 1}/{nam}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Ngày hôm trước là: {ngay - 1}/{thang}/{nam}");
                        }
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (ngay > 30 || ngay < 1)
                    {
                        Console.WriteLine("Nhập sai ngày!!!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tháng có 30 ngày.");
                        //In ra ngày hôm sau:
                        if (ngay == 30)
                        {
                            Console.WriteLine($"Ngày hôm sau là: 1/{thang + 1}/{nam}");
                        }
                        else
                        {
                            Console.WriteLine($"Ngày hôm sau là: {ngay + 1}/{thang}/{nam}");
                        }
                        //In ra ngày hôm trước 
                        if (ngay == 1)
                        {
                            Console.WriteLine($"Ngày hôm trước là: 31/{thang - 1}/{nam}");
                        }
                        else
                        {
                            Console.WriteLine($"Ngày hôm trước là: {ngay - 1}/{thang}/{nam}");
                        }
                    }
                    break;
                case 2:
                    if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                    {
                        if (ngay > 29 || ngay < 1)
                        {
                            Console.WriteLine("Nhập sai ngày!!!!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Tháng có 29 ngày.");
                            //In ra ngày hôm sau
                            if (ngay == 29)
                            {
                                Console.WriteLine($"Ngày hôm sau là: 1/3/{nam}");
                            }
                            else { Console.WriteLine($"Ngày hôm sau là: {ngay + 1}/2/{nam}"); }
                            //In ra ngày hôm trước
                            if (ngay == 1)
                            {
                                Console.WriteLine($"Ngày hôm trước là: 31/1/{nam}");
                            }
                            else { Console.WriteLine($"Ngày hôm trước là: {ngay - 1}/2/{nam}"); }
                        }
                    }
                    else
                    {
                        if (ngay > 28 || ngay < 1)
                        {
                            Console.WriteLine("Nhập sai ngày!!!!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Tháng có 28 ngày.");
                            if (ngay == 28)
                            {
                                Console.WriteLine($"Ngày hôm sau là: 1/3/{nam}");
                            }
                            else { Console.WriteLine($"Ngày hôm sau là: {ngay + 1}/2/{nam}"); }
                            //In ra ngày hôm trước
                            if (ngay == 1)
                            {
                                Console.WriteLine($"Ngày hôm trước là: 31/1/{nam}");
                            }
                            else { Console.WriteLine($"Ngày hôm trước là: {ngay - 1}/2/{nam}"); }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Nhập sai tháng!!!");
                    break;
            }
        }


        //Bài 3:
        static void XuLyMangDiem()
        {
            int count;
            do
            {
                Console.WriteLine("Nhập count: ");
                count = Convert.ToInt32(Console.ReadLine());
                if (count < 0)
                {
                    Console.WriteLine("Nhập số đếm lớn hơn 0!");
                }
            } while (count <= 0);

            double[] arrDiem = new double[count];
            for (int i = 0; i < arrDiem.Length; i++)
            {
                Console.WriteLine($"Nhập điểm thứ {i}: ");
                arrDiem[i] = Convert.ToDouble(Console.ReadLine());
            }
            //3.1: xuất điểm - trượt/đỗ
            for (int i = 0; i < arrDiem.Length; i++)
            {
                if (arrDiem[i] < 5)
                {
                    Console.WriteLine($"Điểm số {i + 1} = {arrDiem[i]}-Trượt.");
                }
                else
                {
                    Console.WriteLine($"Điểm số {i + 1} = {arrDiem[i]}-Đỗ.");
                }
            }
            //3.2: sắp xếp theo thứ tự tăng/giảm
            Array.Sort(arrDiem);
            Console.WriteLine("Điểm theo thứ tự tăng dần là: ");
            foreach (var diem in arrDiem)
            {
                Console.Write($" {diem} ");
            }
            Console.WriteLine("");
            Array.Reverse(arrDiem);
            Console.WriteLine("Điểm theo thứ tự giảm dần là");
            foreach (var diem in arrDiem)
            {
                Console.Write($" {diem} ");
            }
        }


        //Bài 4:
        static void XuLyMangThongTin()
        {
            int stt;
            do
            {
                Console.WriteLine("Nhập số lượng sinh viên: ");
                stt = Convert.ToInt32(Console.ReadLine());
                if (stt < 0)
                {
                    Console.WriteLine("Nhập số sinh viên > 0!");
                }
            } while (stt <= 0);

            string[] arrHoTen = new string[stt];
            int[] arrNamSinh = new int[stt];
            string[] arrMSV = new string[stt];
            int[] arrTuoi = new int[stt];
            //Nhập thông tin sinh viên
            for (int i = 0; i < stt; i++)
            {
                Console.WriteLine($"Nhập thông tin sinh viên {i + 1}: ");
                Console.Write("Nhập họ tên: ");
                arrHoTen[i] = Console.ReadLine();
                Console.Write("Nhập năm sinh: ");
                arrNamSinh[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập mã sinh viên: ");
                arrMSV[i] = Console.ReadLine();
            }
            //Xuất thông tin sinh viên
            for (int i = 0; i < stt; i++)
            {
                arrTuoi[i] = 2023 - arrNamSinh[i];
                if (arrTuoi[i] <= 0)
                {
                    Console.WriteLine("Nhập sai thông tin, mời nhập lại!!!!");
                }
                else
                {
                    Console.WriteLine($"Thông tin sinh viên {i + 1}: {arrHoTen[i]}, {arrNamSinh[i]}, {arrMSV[i]}, {arrTuoi[i]}.");
                }
            }
        }
    }
}