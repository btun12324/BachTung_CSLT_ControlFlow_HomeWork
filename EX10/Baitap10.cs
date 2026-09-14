using System;

namespace CSLT_ControlFlow_HomeWork
{
    internal class EX10
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Số tiền = ");
            decimal soTien = decimal.Parse(Console.ReadLine());

            Console.Write("Mã ngoại tệ = ");
            string maNgoaiTe = Console.ReadLine().ToUpper();

            decimal tyGia = 0m;

            switch (maNgoaiTe)
            {
                case "USD":
                    tyGia = 25400m;
                    break;
                case "EUR":
                    tyGia = 27200m;
                    break;
                case "JPY":
                    tyGia = 165m;
                    break;
                default:
                    Console.WriteLine("Mã ngoại tệ không hợp lệ!");
                    return;
            }

            decimal soTienSauQuyDoi = soTien / tyGia;

            Console.WriteLine($"Số tiền sau quy đổi: {soTienSauQuyDoi:F2} {maNgoaiTe}");

            Console.ReadKey();
        }
    }
}
