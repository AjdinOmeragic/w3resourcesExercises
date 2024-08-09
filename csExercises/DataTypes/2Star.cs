using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num = 0;
        int width = 0;

        Console.Write("Num: ");
        num = int.Parse(Console.ReadLine());

        Console.Write("Width: ");
        width = int.Parse(Console.ReadLine());

        for(int i = width; i > 0; i--) 
        {
            for(int j = i; j > 0; j--) 
            {
                Console.Write(num);
            }
            Console.WriteLine(); 
        }
    }
}
