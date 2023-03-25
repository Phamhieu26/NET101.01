using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI7_MANG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //1. khai bao
            int[] arrSo;
            //2.khoi tao mang
            arrSo = new int[] {1,2,3,4};
            int[] a = {1,2,3,4,5};
            
            int[] arrTuoi = new int[5]; // khoi tao mang co kich thuoc 
            //3. gán giá trị cho mảng
            //vị trí mảng chạy từ 0 - > n-1
            arrTuoi[0] = 20; 
            arrTuoi[1] = 15; 
            arrTuoi[2] = 18; 
            arrTuoi[3] = 16; 
            arrTuoi[4] = 17;
            //4. truy vấn phần tử
            Console.WriteLine($"arrTuoi[3] = {arrTuoi[3]}");

            //5. duyệt mảng
            // cách 1
            for (int i = 0; i < arrTuoi.Length; i++)
            {
                Console.WriteLine($"arrTuoi[{i}] = {arrTuoi[i]}");
            }
            //cách 2: foreach
            //fore tab
            foreach (var tuoi in arrTuoi)
            {
                Console.WriteLine(tuoi);
            }

            //-------------------------------------------------------------------------
            // Thao tác mảng

            string[] arrMonHoc = {"Java","C#","MKT","Eng"};
            double[] arrDiemTrungbinh = { 8.2, 9.4, 7.3, 6.8 };
            Console.WriteLine("Mảng môn học");
            //sort sx tăng dần
            //reverse đảo ngược lại chuỗi

            Array.Sort(arrMonHoc);
            Array.Reverse(arrMonHoc);
            Array.Sort(arrDiemTrungbinh);
            Array.Reverse(arrDiemTrungbinh);
            for (int i = 0; i < arrMonHoc.Length; i++)
            {
                Console.WriteLine(arrMonHoc[i]);
            }
            Console.WriteLine("Mảng điểm");
            foreach (var item in arrDiemTrungbinh)
            {
                Console.WriteLine(item);
            }
        }
    }
}
