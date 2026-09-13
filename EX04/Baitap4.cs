using System;

namespace CSLT_ControlFlow_HomeWork
{
    internal class EX04
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Phím bấm = ");

            bool check = true;

            do
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("[TỔNG ĐÀI]: Yêu cầu gặp tổng đài viên tư vấn thẻ đã được ghi nhận.");
                        check = false;
                        break;
                    case 2:
                        Console.WriteLine("[TỔNG ĐÀI]: Yêu cầu tra cứu số dư tài khoản đã được ghi nhận.");
                        check = false;
                        break;
                    case 3:
                        Console.WriteLine("[TỔNG ĐÀI]: Yêu cầu khóa thẻ khẩn cấp đã được ghi nhận.");
                        check = false;
                        break;
                    case 4:
                        Console.WriteLine("[TỔNG ĐÀI]: Yêu cầu tra cứu tỷ giá ngoại tệ đã được ghi nhận.");
                        check = false;
                        break;
                    case 0:
                        Console.WriteLine("[TỔNG ĐÀI]: Yêu cầu quay lại menu chính đã được ghi nhận.");
                        check = false;
                        break;
                    default:
                        Console.WriteLine("!!! Lựa chọn không hợp lệ. Vui lòng nhập lại !!!");
                        break;
                }
            } while (check);

            Console.ReadKey();
        }
    }
}
