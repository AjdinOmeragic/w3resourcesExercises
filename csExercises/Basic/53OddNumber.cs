using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr1 = {2, 4, 7, 8, 6};
        for(int i = 0; i < arr1.Length; i++)
        {
            if(arr1[i] % 2 != 0)
            {
                Console.WriteLine("True");
            }
        }
    }
}
