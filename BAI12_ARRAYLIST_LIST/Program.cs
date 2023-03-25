using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI12_ARRAYLIST_LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Khởi tạo arrlist
            ArrayList arrLstTuoi = new ArrayList();
            //2. Thêm phần tử vào mảng arrList
            arrLstTuoi.Add(10);
            arrLstTuoi.Add(5);
            arrLstTuoi.Add(18);
            arrLstTuoi.Add(32);
            arrLstTuoi.Add(24);
            ////////////////////////////
            arrLstTuoi.Add("Mk1");
            arrLstTuoi.Add(true);

            //3. truy vấn phần tử
            Console.WriteLine(arrLstTuoi[0]);
            Console.WriteLine(arrLstTuoi[1]);
            Console.WriteLine(arrLstTuoi[2]);

            //4.Duyệt arrlist
            Console.WriteLine("Cach 1: for tab");
            for (int i = 0; i < arrLstTuoi.Count; i++)
            {
                Console.WriteLine($"arrLstTuoi[{i + 1}] = {arrLstTuoi[i]}");
            }

            Console.WriteLine("Cach 2: fore tab");
            foreach (var item in arrLstTuoi)
            {
                Console.WriteLine(item);
            }
            ////////////////////////////
            //1. Khởi tạo
            List<string> lstTen = new List<string>();
            //2. Thêm phần tử
            lstTen.Add("Mai");
            lstTen.Add("Dao");
            lstTen.Add("Hoa");
            lstTen.Add("Tuyet");
            lstTen.Add("Nhung");
            //3. truy xuất
            Console.WriteLine(lstTen[0]);
            //4. Duyet
            //For i
            //Sap xep
            lstTen.Sort(); // tăng dần
            for (int i = 0; i < lstTen.Count; i++)
            {
                Console.WriteLine($"lstTen[{i + 1}] = {lstTen[i]}");
            }
            // Xoá phần tử tại vị trí i
            lstTen.RemoveAt(1);
            // Xoá phần tử có giá trị ...
            lstTen.Remove("Hoa");
            //foreach
            lstTen.Reverse(); // Đảo ngược
            foreach (var item in lstTen)
            {
                Console.WriteLine(item);
            }
            // Xoá toàn bộ phần tử
            lstTen.Clear();
            Console.WriteLine($"count: {lstTen.Count}");
            if (lstTen.Count == 0)
            {
                Console.WriteLine("Danh sach trong!!!!");
            }
        }
    }
}
