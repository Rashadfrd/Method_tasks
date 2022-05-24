using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 4, 4, 8, 9 };
            int number = 4;
            int result = Index(number, numbers);
            Console.WriteLine(result);

            
        }
        static int Index(int num , int[] nums)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num)
                {
                    index = i;
                    break;
                }
            }
            return index;
            
            
        }
    }
}
