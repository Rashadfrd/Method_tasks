using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = DigitSum(45699);
            Console.WriteLine(num);
        }

        static int DigitSum(int num)
        {
            int sum = 0;
            int lastDigit = 0;
            while (num != 0)
            {
                lastDigit = num % 10;
                num = (num - lastDigit) / 10;
                sum+=lastDigit;

            }
            return sum;
        }
    }
}
