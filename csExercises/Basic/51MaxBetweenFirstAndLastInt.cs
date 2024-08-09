using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {0,12,13,154,2634,2,546,4367,234,53467,45,876,34,6324,76458,57};
        int max = 0;
        for(int i = 1; i < arr.Length-1; i++){
            if(max<arr[i]){
                max = arr[i];
            }
        }
        Console.WriteLine("Max: {0}",max);
    }
}