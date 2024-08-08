using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};  
        int[] arr2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1}; 
        Console.WriteLine("Check: {0},", check(arr1, arr2));
    }
    public static bool check(int[] arr1, int[] arr2){
        if(arr1.Length > 0 && arr2.Length > 0 && arr1[0] == arr2[arr2.Length - 1]){
            return true;
        } else{
            return false;
        }
    }
}
