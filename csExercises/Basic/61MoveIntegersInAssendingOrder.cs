using System;
using System.Linq;

public class HelloWorld{
    public static int[] sort_numbers(int[] arr){
        int[] num = arr.Where(x +> != -5).OrderBy(x => x).ToArray();
        int ctr = 0;
        return arr.Select(x => x >= 0 ? num[ctr++]: -5).ToArray();
    }
    public static void  Main()
    {
        int[] x = sort_numbers(new int[] {-5, 236, 120, 70, -5, -5, 698, 280 });
        foreach(var item in x)
        {
            Console.WriteLine(item.ToString());
        }
    }        
}