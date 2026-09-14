using System;

namespace CSLT_ControlFlow_HomeWork
{
    internal class EX09
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("GPA = ");
            double gpa = double.Parse(Console.ReadLine());

            Console.WriteLine("DRL = ");
            int drl = int.Parse(Console.ReadLine());

            if(gpa >= 3.6 && drl >= 90)
            {
                Console.WriteLine("Kết quả: Học bổng Xuất sắc (Mức 100%)");
            }
            else if(gpa >= 3.2 && drl >= 80)
            {
                Console.WriteLine("Kết quả: Học bổng Khá/Giỏi (Mức 50%)");
            }
            else
            {
                Console.WriteLine("Kết quả: Không đạt học bổng!");
            }

            Console.ReadKey();
        }
    }
}