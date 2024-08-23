using System;

class Program
{
    static void Main()
    {
        int[] testCases = { 1, 2, 4, 100 };
        
        foreach (var n in testCases)
        {
            int nthOdd = getOdd(n);
            Console.WriteLine($"{n}th odd num: {nthOdd}");
        }
    }

    static int getOdd(int n)
    {
        return 2 * n - 1;
    }
}
