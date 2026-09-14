using System;

namespace CSLT_ControlFlow_HomeWork
{
    internal class EX07
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Cân nặng = ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Chiều cao = ");
            double height = double.Parse(Console.ReadLine());

            double BMI = weight / (height * height);
            BMI = Math.Round(BMI, 2);

            if (BMI < 18.5)
            {
                Console.WriteLine("BMI: " + BMI + " - Đánh giá : Gầy - Nên bổ sung dinh dưỡng.");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("BMI: " + BMI + " - Đánh giá : Cân đối - tiếp tục duy trì.");
            }
            else if (BMI >= 25 && BMI <30)
            {
                Console.WriteLine("BMI: " + BMI + " - Đánh giá : Thừa cân - Nên tăng cường luyện tập.");
            }
            else
            {
                Console.WriteLine("BMI: " + BMI + " - Đánh giá : Béo phì - Cần sự tư vấn từ bác sĩ.");
            }

            Console.ReadKey();
        }
    }
}