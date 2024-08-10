using System;
using System.Linq;

public class CustomSort
{
    public static int[] PreserveAndSort(int[] inputArray)
    {
        int[] sortedValues = inputArray.Where(num => num != -5).OrderBy(num => num).ToArray();
        int index = 0; 
        return inputArray.Select(element => element == -5 ? -5 : sortedValues[index++]).ToArray();
    }

    public static void Main()
    {
        int[] resultArray = PreserveAndSort(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 });
        foreach (var value in resultArray)
        {
            Console.WriteLine(value);
        }
    }
}
