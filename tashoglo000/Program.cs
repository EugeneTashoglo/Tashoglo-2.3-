using System;

namespace tashoglo000
{
    class Program
    {
        static void Main(string[] args)
          
        {
            try
            {
                Console.WriteLine("Введите 1,2,3: ");
                int n = int.Parse(Console.ReadLine());
                double x = double.Parse(Console.ReadLine());
                double a = 0, b = 0, z=0 , y;
                switch (n)
                {
                    case 1: a = 8.7; b = 3.7; z = Math.Tan(b * x); break;
                    case 2: a = 9.3; b = 3.5; z = Math.Tan(a * b * x); break;
                    case 3: a = 2.1; b = 5.7; z = Math.Tan(b * b * x); break;
                }
                
                if (x < a) y = x * Math.Exp(x) + (z + 7.7 * a * b * x);
                else if (a <= x && x <= b * b) y = Math.Tan(a * x + z) + Math.Pow(Math.Cos(b * x), 2);
                else y = Math.Log(Math.Pow(Math.Sin(a + b * x + z * x * x),2));
                Console.WriteLine($"y={y:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
