using System;

namespace Class2
{
    class Program
    {
        public class Nguoi
        {
            #region Nguoi Fields
            private string nHoTen;
            private DateTime nNgaySinh;
            private string nDiaChi;
            #endregion

            #region Nguoi Constructor
            public Nguoi()
            {
                nHoTen = "null";
                nNgaySinh = new DateTime(1900, 1, 1);
                nDiaChi = "null";
            }

            public Nguoi(string hoten, DateTime ngaysinh, string diachi)
            {
                nHoTen = hoten;
                nNgaySinh = ngaysinh;
                nDiaChi = diachi;
            }
            #endregion

            #region get - set Nguoi 
            public string HoTen
            {
                get { return nHoTen; }
                set { nHoTen = value; }
            }
            public DateTime NgaySinh
            {
                get { return nNgaySinh; }
                set { nNgaySinh = value; }
            }
            public string DiaChi
            {
                get { return nDiaChi; }
                set { nDiaChi = value; }
            }
            public int LayTuoi
            {
                get
                {
                    return DateTime.Today.Year - NgaySinh.Year;
                }
            }
            #endregion

            #region XemThongTin - Nguoi
            public virtual void XemThongTin()
            {
                Console.WriteLine("Ho ten: {0}\nNgay sinh: {1}\nDia chi: {2}\nTuoi: {3}", HoTen, NgaySinh.ToString("dd/MM/yyyy"), DiaChi, LayTuoi);
            }
            #endregion

            #region Nhap - Nguoi
            public virtual void Nhap()
            {
                Console.Write("Ho ten: ");
                HoTen = Console.ReadLine();
                Console.Write("Ngay sinh (mm/dd/yyyy): ");
                NgaySinh = DateTime.Parse(Console.ReadLine());
                Console.Write("Dia chi: ");
                DiaChi = Console.ReadLine();
            }
            #endregion
        }

        public class SinhVien : Nguoi
        {
            #region SinhVien Fields
            private string nMaSV;
            private string nMaLop;
            private string nEmail;
            private string nDienThoai;
            #endregion

            #region SinhVien Constructor
            public SinhVien()
            {
                nMaSV = "null";
                nMaLop = "null";
                nEmail = "null";
                nDienThoai = "null";
            }

            public SinhVien(string hoten, DateTime ngaysinh, string diachi, string masv, string malop, string email, string dienthoai)
            {
                HoTen = hoten;
                NgaySinh = ngaysinh;
                DiaChi = diachi;
                nMaSV = masv;
                nMaLop = malop;
                nEmail = email;
                nDienThoai = dienthoai;
            }
            #endregion

            #region get - set SinhVien
            public string MaSV
            {
                get { return nMaSV; }
                set { nMaSV = value; }
            }

            public string MaLop
            {
                get { return nMaLop; }
                set { nMaLop = value; }
            }

            public string Email
            {
                get { return nEmail; }
                set { nEmail = value; }
            }

            public string DienThoai
            {
                get { return nDienThoai; }
                set { nDienThoai = value; }
            }
            #endregion

            #region XemThongTin - SinhVien
            public override void XemThongTin()
            {
                base.XemThongTin();
                Console.WriteLine("Ma sinh vien: {0}\nMa lop: {1}\nEmail: {2}\nSo dien thoai: {3}", MaSV, MaLop, Email, DienThoai);
            }
            #endregion

            #region Nhap - SinhVien
            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Ma sinh vien: ");
                MaSV = Console.ReadLine();
                Console.Write("Ma lop: ");
                MaLop = Console.ReadLine();
                Console.Write("Email: ");
                Email = Console.ReadLine();
                Console.Write("So dien thoai: ");
                DienThoai = Console.ReadLine();
            }
            #endregion
        }

        public class NhanVien : Nguoi
        {
            # region NhanVien Fields
            private string nMaNV;
            private string nEmail;
            private string nDienThoai;
            private DateTime nNgayLamViec;
            private string nMaCongTy;
            #endregion

            #region NhanVien Constructor
            public NhanVien()
            {
                nMaNV = "null";
                nEmail = "null";
                nDienThoai = "null";
                nNgayLamViec = new DateTime(1900, 1, 1);
                nMaCongTy = "null"; 
            }

            public NhanVien(string hoten, DateTime ngaysinh, string diachi, string manv, string email, string dienthoai, DateTime ngaylamviec, string macongty)
            {
                HoTen = hoten;
                NgaySinh = ngaysinh;
                DiaChi = diachi;
                nMaNV = manv;
                nEmail = email;
                nDienThoai = dienthoai;
                nNgayLamViec = ngaylamviec;
                nMaCongTy = macongty;
            }
            #endregion

            #region get - set NhanVien
            public string MaNV
            {
                get { return nMaNV; }
                set { nMaNV = value; }
            }
            public string Email
            {
                get { return nEmail; }
                set { nEmail = value; }
            }

            public string DienThoai
            {
                get { return nDienThoai; }
                set { nDienThoai = value; }
            }

            public DateTime NgayLamViec
            {
                get { return nNgayLamViec; }
                set { nNgayLamViec = value; }
            }

            public string MaCongTy
            {
                get { return nMaCongTy; }
                set { nMaCongTy = value; }
            }

            #endregion

            #region XemThongTin - NhanVien
            public override void XemThongTin()
            {
                base.XemThongTin();
                Console.WriteLine("Ma nhan vien: {0}\nEmail: {1}\nSo dien thoai: {2}\nNgay lam viec: {3}\nMa cong ty: {4}", MaNV, Email, DienThoai, NgayLamViec.ToString("dd/MM/yyyy"), MaCongTy);
            }
            #endregion

            #region Nhap - NhanVien
            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Ma nhan vien: ");
                MaNV = Console.ReadLine();
                Console.Write("Email: ");
                Email = Console.ReadLine();
                Console.Write("So dien thoai: ");
                DienThoai = Console.ReadLine();
                Console.Write("Ngay lam viec (mm/dd/yyyy): ");
                NgayLamViec = DateTime.Parse(Console.ReadLine());
                Console.Write("Ma cong ty: ");
                MaCongTy = Console.ReadLine();
            }
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine("______________________________SINH VIEN______________________________");
            SinhVien SV1 = new SinhVien();
            SV1.Nhap();
            Console.WriteLine();
            SV1.XemThongTin();

            Console.WriteLine("\n______________________________NHAN VIEN______________________________");
            NhanVien NV1 = new NhanVien();
            NV1.Nhap();
            Console.WriteLine();
            NV1.XemThongTin();
            Console.ReadKey();
        }
    }
}