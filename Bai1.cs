using System;
using System.Collections.Generic;

namespace Class_1
{
    class Program
    {
        public class HinhHoc
        {
            public double DienTich { get; set; }
            public double ChuVi { get; set; }
            
            public virtual void tinhDienTichChuVi()
            {

            }

            public override string ToString()
            {
                return string.Format("S = {0}; P = {1}.", Math.Round(DienTich, 2), Math.Round(ChuVi, 2));
            }
        }

        public class HinhChuNhat : HinhHoc
        {
            private double mChieuDai;
            private double mChieuRong;
            public double ChieuDai
            {
                get { return mChieuDai; }
                set
                {
                    if (value > 0) mChieuDai = value;
                    else throw new Exception("Chieu dai am");
                }
            }
            public double ChieuRong
            {
                get { return mChieuRong; }
                set
                {
                    if (value > 0) mChieuRong = value;
                    else throw new Exception("Chieu rong am");
                }
            }

            public HinhChuNhat (double d = 1, double r = 0.5)
            {
                ChieuDai = d;
                ChieuRong = r;
            }
            public override void tinhDienTichChuVi()
            {
                DienTich = ChieuDai * ChieuRong;
                ChuVi = (ChieuDai + ChieuRong) * 2;
            }
            public override string ToString()
            {
                return string.Format("L = {0}, W = {1}; {2}", ChieuDai, ChieuRong, base.ToString());
            }

        }

        public class HinhTron : HinhHoc
        {
            private double mBanKinh;
            private double Pi = 3.14;
            public double BanKinh
            {
                get { return mBanKinh; }
                set
                {
                    if (value > 0) mBanKinh = value;
                    else throw new Exception("Ban kinh am");
                }
            }

            public HinhTron (double r = 1)
            {
                BanKinh = r;
            }
            public override void tinhDienTichChuVi()
            {
                DienTich = Pi * BanKinh * BanKinh;
                ChuVi = 2 * Pi * BanKinh;
            }
            public override string ToString()
            {
                return string.Format("R = {0}; {1}", BanKinh, base.ToString());
            }

        }

        static void Main(string[] args)
        {
            HinhChuNhat a = new HinhChuNhat();
            Console.WriteLine("______________________________HINH CHU NHAT______________________________");
            Console.Write("Chieu dai = ");
            a.ChieuDai = double.Parse(Console.ReadLine());
            Console.Write("Chieu rong = ");
            a.ChieuRong = double.Parse(Console.ReadLine());
            a.tinhDienTichChuVi();
            Console.WriteLine("HCN: " + a.ToString());

            Console.WriteLine("______________________________HINH TRON______________________________");
            HinhTron b = new HinhTron();
            Console.Write("Ban Kinh = ");
            b.BanKinh = double.Parse(Console.ReadLine());
            b.tinhDienTichChuVi();
            b.ToString();
            Console.WriteLine("HT: " + b.ToString());

            Console.ReadKey();
        }
    }
}
