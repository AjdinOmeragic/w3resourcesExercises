/*
26. Write a C# program to compute the sum of the first 500 prime numbers.
Sample Output:
Sum of the first 500 prime numbers:
824693
*/

using System;

public class PrimeSum
{
    public static void Main(string[] args)
    {
        int count = 0;
        int sum = 0;
        int num = 2; 

        while (count < 500)
        {
            if (primeNumber(num))
            {
                sum += num;
                count++;
            }
            num++;
        }

        Console.WriteLine("Sum of 500 prime numbers: {0}", sum);
    }

    public static bool primeNumber(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true; 
        if (num % 2 == 0) return false; 
        
        int sqrtN = (int)Math.Sqrt(num);
        for (int i = 3; i <= sqrtN; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
