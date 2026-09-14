using System;

namespace CSLT_ControlFlow_HomeWork
{
    internal class EX06
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Trạng thái = ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Chờ xác nhận thanh toán.");
                    break;
                case 2:
                    Console.WriteLine("Đang đóng gói và bàn giao đơn vị vận chuyển.");
                    break;
                case 3:
                    Console.WriteLine("Đơn hàng đang trên đường giao đến bạn.");
                    break;
                case 4:
                    Console.WriteLine("Đơn hàng đã hoàn thành. Cảm ơn bạn!");
                    break;
                case 5:
                    Console.WriteLine("Đơn hàng đã hủy. Xuất phiếu hoàn tiền.");
                    break;
            }    

            Console.ReadKey();
        }
    }
}