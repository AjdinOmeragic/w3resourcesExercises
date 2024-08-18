using System;

class SumOfNaturalNumbers
{
    static void Main()
    {
        Console.Write("Enter the numb: ");
        int n =Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("SUM:" + n + " is: " + sum);
    }
}
