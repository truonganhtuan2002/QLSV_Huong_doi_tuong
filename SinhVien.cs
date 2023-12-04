using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class SinhVien:Nguoi
    {
        double diemT;
        double diemV;

        public SinhVien() : base()
        {

        }
        public SinhVien( string hoten ,string gioitinh, string quequan, int namsinh,double diemT,double diemV) : base(hoten,gioitinh,quequan,namsinh)
        {
            this.diemT = diemT;
            this.diemV = diemV;
        }
        
        public void NhapTT()
        {
            base.Nhap();
            Console.Write("Nhap diem toan : ");diemT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem van : "); diemV = Convert.ToDouble(Console.ReadLine());
        }
        public void XuatTT()
        {
            base.Xuat();
            Console.WriteLine("DiemT :" + diemT);
            Console.WriteLine("DiemV :" + diemV);
            Console.WriteLine("DiemTB : " + DiemTB());
        }
        public double DiemTB()
        {
            return ((diemT + diemV) / 2);
        }
    }
}
