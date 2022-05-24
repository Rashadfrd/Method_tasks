using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = Biggest(38, 7, 19);
            Console.WriteLine(numbers);
        }
        static int Biggest(int num1, int num2, int num3)
        {
            int result = 0;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    result = num1;
                    return result;
                }
                else
                {
                    result = num3;
                    return result;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    result = num2;
                    return result;
                }
                else
                {
                    result = num3;
                    return result;
                }
            }
        }
    }
}
