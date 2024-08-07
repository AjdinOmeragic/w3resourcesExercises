using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = new int[10]; 
        int sum = 0;

        for(int i = 0; i < 10; i++)
        {
            Console.Write("Enter number: ");
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        double average = (double)sum / 10; 
        Console.WriteLine("Average: {0}", average);
    }
}
