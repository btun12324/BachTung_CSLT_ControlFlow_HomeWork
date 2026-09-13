using System;

namespace CSLT_ControlFlow_HomeWork
{
    internal class EX03
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--INPUT--");

            Console.WriteLine("Số dư: ");
            int sodu = int.Parse(Console.ReadLine());

            Console.WriteLine("Số tiền rút: ");
            int tienrut = int.Parse(Console.ReadLine());

            if(tienrut <= 0)
            {
                Console.WriteLine("Lỗi! Số tiền rút phải lớn hơn 0");
            }
            else if(tienrut % 50000 != 0)
            {
                Console.WriteLine("Lỗi! Số tiền rút phải là bội số của 50,000");
            }    
            else if(tienrut > sodu)
            {
                Console.WriteLine("Lỗi! Số tiền rút lớn hơn số dư hiện tại");
            }
            else if(tienrut > 5000000)
            {
                Console.WriteLine("Lỗi! Số tiền rút vượt quá hạn mức");
            }    
            else
            {
                Console.WriteLine( "Giao dịch thành công, số dư còn lại: " + (sodu - tienrut) + " VNĐ");
            }    

            Console.ReadKey();
        }
    }
}
