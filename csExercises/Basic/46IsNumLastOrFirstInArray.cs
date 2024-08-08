using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {0, 1, 12, 24, 25, 364267, 226, 23437, 1};
        int num = 0;
        Console.WriteLine("Enter a value: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("Value is: {0}", val(num, arr));
    }

    public static bool val(int num, int[] arr)
    {
        if (arr[0] == num)
        {
            return true;
        }
        else if (arr[arr.Length - 1] == num)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
