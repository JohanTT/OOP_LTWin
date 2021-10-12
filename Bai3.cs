using System;

namespace Class_3
{
    class Program
    {
        public class DaThuc
        {
            #region DaThuc Fields
            public double[] a;
            public int n;
            public double x;
            #endregion

            #region DaThuc Constructor
            public DaThuc(int bac)
            {
                n = bac;
                a = new double [n + 1];
                for (int i = 0; i <= n; i++)
                {
                    a[i] = 0;
                }
                x = 0;
            }
            #endregion

            #region Cong DaThuc
            public static DaThuc operator + (DaThuc M, DaThuc N)
            {
                int max = Math.Max(M.n, N.n); // Lay Bac cao nhat cua 2 da thuc
                int min = Math.Min(M.n, N.n); // Lay Bac thap nhat cua 2 da thuc
                DaThuc Tong = new DaThuc(max);

                if (M.n == N.n) // TH1 Bac cua M == N
                {
                    for (int i = 0; i <= max; i++) 
                        Tong.a[i] = M.a[i] + N.a[i]; 
                }
                else // Bac cua M != N
                {
                    for (int i = 0; i <= min; i++) // Tinh tong Da thuc chung cua bac nho nhat
                        Tong.a[i] = M.a[i] + N.a[i];

                    if (M.n > N.n) // TH2 Bac cua M > N
                        for (int i = N.n; i <= M.n; i++) // Lay cac phan tu con lai cua da thuc
                            Tong.a[i] = M.a[i];
                    else           // TH3 Bac cua M < N
                        for (int i = M.n; i <= N.n; i++) // Lay cac phan tu con lai cua da thuc
                            Tong.a[i] = N.a[i];
                }
                return Tong;
            }
            #endregion

            #region Tru DaThuc
            public static DaThuc operator - (DaThuc M, DaThuc N)
            {
                int max = Math.Max(M.n, N.n); // Lay Bac cao nhat cua 2 da thuc
                int min = Math.Min(M.n, N.n); // Lay Bac thap nhat cua 2 da thuc
                DaThuc Hieu = new DaThuc(max);

                if (M.n == N.n) // TH1 Bac cua M == N
                {
                    for (int i = 0; i <= max; i++)
                        Hieu.a[i] = M.a[i] - N.a[i];
                }
                else // Bac cua M != N
                {
                    for (int i = 0; i <= min; i++) // Tinh hieu da thuc chung cua bac nho nhat
                        Hieu.a[i] = M.a[i] - N.a[i];

                    if (M.n > N.n) // TH2 Bac cua M > N
                        for (int i = N.n; i <= M.n; i++) // Lay cac phan tu con lai cua da thuc
                            Hieu.a[i] = M.a[i]; 
                    else           // TH3 Bac cua M < N
                        for (int i = M.n; i <= N.n; i++) // Lay cac phan tu con lai cua da thuc
                            Hieu.a[i] = N.a[i];
                }
                return Hieu;
            }
            #endregion

            #region Propety Bac DaThuc
            public int Bac
            {
                get { return n; }
            }
            #endregion

            #region Indexer DaThuc
            public double this [int k]
            {
                get { return a[k]; }
                set { a[k] = value; }
            }
            #endregion

            #region Tinh DaThuc
            public double Tinh (double b)
            {
                double KQ = 0;
                x = b;
                for (int i = 0; i <= n; i++)
                    KQ += a[i] * Math.Pow(x, i);
                return KQ;
            }
            #endregion

            // Xuat Da Thuc
            public void Xuat()
            {
                for (int i = n; i >= 0; i--)
                {
                    if (a[i] > 0 && i < n && a[i] != 0) Console.Write(" + ");
                    if (a[i] < 0 && i < n && a[i] != 0) Console.Write(" ");
                    if (a[i] != 0)
                    {
                        Console.Write(a[i]);
                        if (i > 1) Console.Write("x^{0}", i);
                        if (i == 1) Console.Write("x");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("______________________________DA THUC______________________________");
            Console.Write("Nhap bac da thuc 1: ");
            int sl1 = int.Parse(Console.ReadLine());
            DaThuc F1 = new DaThuc(sl1);

            Console.Write("Nhap bac da thuc 2: ");
            int sl2 = int.Parse(Console.ReadLine());
            DaThuc F2 = new DaThuc(sl2);

            Console.WriteLine("Nhap phan tu da thuc 1: ");
            for (int i = 0; i <= sl1; i++)
            {
                Console.Write("x{0} = ", i);
                F1[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nhap phan tu da thuc 2: ");
            for (int i = 0; i <= sl2; i++)
            {
                Console.Write("x{0} = ", i);
                F2[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Da Thuc 1 = ");
            F1.Xuat();
            Console.Write("Da Thuc 2 = ");
            F2.Xuat();
            Console.ReadKey();

            Console.WriteLine();
            Console.Write("Da Thuc 1 + Da Thuc 2 = ");
            DaThuc F3 = F1 + F2;
            F3.Xuat();
            Console.Write("Da Thuc 1 - Da Thuc 2 = ");
            DaThuc F4 = F1 - F2;
            F4.Xuat();
            Console.ReadKey();

            Console.WriteLine();
            Console.Write("Nhap x de tinh gia tri 2 da thuc: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Da Thuc 1 = " + F1.Tinh(b).ToString());
            Console.WriteLine("Da Thuc 2 = " + F2.Tinh(b).ToString());
            Console.ReadKey();
        }
    }
}
