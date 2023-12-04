using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class Nguoi
    {
        protected string hoten { get; set; }
        protected string gioitinh { get; set; }
        protected string quequan { get; set; }
        protected int namsinh { get; set; }

        public Nguoi()
        {

        }
        public Nguoi(string hoten, string gioitinh, string quequan, int namsinh)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.quequan = quequan;
            this.namsinh = namsinh;
        }
        public void Nhap()
        {
            Console.Write("Nhap Ten : "); hoten = Console.ReadLine();
            Console.Write("Nhap gioi tinh : "); gioitinh = Console.ReadLine();
            Console.Write("Nhap que quan : "); quequan = Console.ReadLine();
            Console.Write("Nhap nam sinh : "); namsinh = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("HoTen: " + hoten);
            Console.WriteLine("GioiTinh: " + gioitinh);
            Console.WriteLine("QueQUan: " + quequan);
            Console.WriteLine("NamSinh: " + namsinh);
            Console.WriteLine("Tuoi : " +TinhTuoi());
        }
        public int TinhTuoi()
        {
            return DateTime.Now.Year - namsinh;
        }
    }
}
