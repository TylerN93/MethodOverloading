using System;

namespace MethodOverloading
{
    internal class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isTrue)
        {
            int sum = x + y;
            if (isTrue = true && sum > 1)
            {
                return $"{sum} dollars";
            }
           else if (isTrue = true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return "sum";
            }
        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            double a = 1.5;
            double b = 1.5;

            int answer = Add(x, y);
            
            double answer2 = Add(a, b);

            string answer3 = Add(x, y, true);

            Console.WriteLine(answer);

            Console.WriteLine(answer2);

            Console.WriteLine(answer3);

        }
    }
}
