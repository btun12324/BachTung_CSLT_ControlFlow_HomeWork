using System;

namespace ControlFlow_HomeWork
{
    internal class EX01
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Tuổi: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Giờ chiếu: ");
            int time = int.Parse(Console.ReadLine());

            int giave = 0;

            if (age < 12 || age > 60)
            {
                giave = 50000;
            }
            else
            {
                if (time < 17)
                {
                    giave = 80000;
                }
                else
                {
                    giave = 110000;
                }
            }

            Console.WriteLine("Giá vé của bạn là: " + giave + " VNĐ");

            Console.ReadKey();
        }
    }
}