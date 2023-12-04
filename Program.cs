using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class QLSV
    {
        private int n;
        SinhVien[] sv;

        public void NhapSV()
        {
            Console.Write("Nhap so sinh vien : "); n = int.Parse(Console.ReadLine());
            sv = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin SV thu {0} : " + (i + 1));
                sv[i] = new SinhVien();
                sv[i].NhapTT();
            }       
        }
        public void XuatSV()
        {
            Console.WriteLine("----------------Thong tin sinh vien --------------");
            for (int i = 0; i < n; i++)
            {
                sv[i].XuatTT();
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            QLSV qlsv = new QLSV();
            qlsv.NhapSV();
            qlsv.XuatSV();

            Console.ReadKey();
        }
    }
}
