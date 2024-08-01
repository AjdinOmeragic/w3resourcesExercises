/*
2. Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.

Sample Input:
53
30
51
Expected Output:
6
21
0
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(absolouteTest(53));
        Console.WriteLine(absolouteTest(30));
        Console.WriteLine(absolouteTest(51));
    }
    public static int absolouteTest(int num){
        if(num>51){
            return 3*(num-51);
        } else if(num<0) {
            return -1*(num+51);
        } else {
            return -1*(num-51);
        }
    }
}