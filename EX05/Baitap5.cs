using System;

namespace CSLT_ControlFlow_HomeWork
{
    internal class EX05
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Số Km = ");
            int distance = int.Parse(Console.ReadLine());

            double tongtien = 0;

            if (distance >= 2 && distance <= 10)
            {
                tongtien = 15000 + (distance - 1) * 12000;
            }
            else
            {
                tongtien = 15000 + 9 * 12000 + (distance - 10) * 10000;
            }

            if(distance > 30)
            {
                Console.WriteLine("Tổng tiền trước giảm: " + tongtien + " VNĐ");
                Console.WriteLine("Khuyến mãi (10%): -" + tongtien * 1/10 + " VNĐ");
                Console.WriteLine("Thành tiền: " + tongtien * 9/10 + " VNĐ");
            }
            else
            {
                Console.WriteLine("Thành tiền: " + tongtien + " VNĐ");
            }    

            Console.ReadKey();
        }
    }
}