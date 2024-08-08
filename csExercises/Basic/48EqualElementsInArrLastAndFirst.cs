using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};  
        Console.WriteLine("Check: {0},", check(arr));
    }
    public static bool check(int[] arr){
        if(arr.Length > 0 && arr[0] == arr[arr.Length - 1]){
            return true;
        } else{
            return false;
        }
    }
}
