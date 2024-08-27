using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 3, 4, 2 };
            Console.WriteLine("Sum of arr" + test(arr1));
            Console.WriteLine("Sum of arr" + test(arr2));
        }
        public static int test(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num * num;
            }
            return sum;
        }
    }
}
