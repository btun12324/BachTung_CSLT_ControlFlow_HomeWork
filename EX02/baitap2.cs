using System;

namespace CSLT_ControlFlow_HomeWork
{
    internal class EX02
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Role: ");
            string role = Convert.ToString(Console.ReadLine());

            switch (role)
            {
                case "ADMIN":
                    Console.WriteLine("Toàn quyền quản trị hệ thống.");
                    break;
                case "MANAGER":
                    Console.WriteLine("Quyền quản lý nhân sự và xem báo cáo.");
                    break;
                case "EMPLOYEE":
                    Console.WriteLine("Quyền tạo và chỉnh sửa hồ sơ cá nhân.");
                    break;
                case "GUEST":
                    Console.WriteLine("Chỉ có quyền xem thông tin công khai.");
                    break;
                default:
                    Console.WriteLine("Mã vai trò không hợp lệ!");
                    break;
            }

            Console.ReadKey();
        }
    }
}