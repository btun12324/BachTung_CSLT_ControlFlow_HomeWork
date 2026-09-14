using System;

namespace CSLT_ControlFlow_HomeWork
{
    internal class EX08
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Loại xe (BIKE/CAR): ");
            string loaiXe = Console.ReadLine().ToUpper();

            Console.Write("Thời gian (1: Ban ngày, 2: Ban đêm): ");
            int thoiGian = int.Parse(Console.ReadLine());

            decimal phiGuiXe = 0m;
            string tenXeTiengViet = "";
            string buoiGuiXe = "";

            if (thoiGian == 1)
            {
                buoiGuiXe = "Ban ngày";
            }
            else if (thoiGian == 2)
            {
                buoiGuiXe = "Ban đêm";
            }
            else
            {
                Console.WriteLine("Lỗi: Thời gian không hợp lệ! Vui lòng nhập 1 hoặc 2.");
                return;
            }

            switch (loaiXe)
            {
                case "BIKE":
                    tenXeTiengViet = "Xe máy";
                    if (thoiGian == 1)
                    {
                        phiGuiXe = 5000m;
                    }
                    else 
                    {
                        phiGuiXe = 10000m;
                    }
                    break;

                case "CAR":
                    tenXeTiengViet = "Ô tô";
                    if (thoiGian == 1)
                    {
                        phiGuiXe = 30000m;
                    }
                    else 
                    {
                        phiGuiXe = 60000m;
                    }
                    break;

                default:
                    Console.WriteLine("Lỗi: Loại xe không hợp lệ! Vui lòng nhập BIKE hoặc CAR.");
                    return; 
            }

            Console.WriteLine($"Phí gửi xe {tenXeTiengViet} ({buoiGuiXe}): {phiGuiXe:#,##0} VNĐ");
        }

        Console.ReadKey();
        }
    }
}