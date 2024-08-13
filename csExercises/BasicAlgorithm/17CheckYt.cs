using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(CheckAndRemoveYT("Python")); 
        Console.WriteLine(CheckAndRemoveYT("ytade"));  
        Console.WriteLine(CheckAndRemoveYT("jsues"));  
    }
    
    public static string CheckAndRemoveYT(string str)
    {
    
        if (str.Length > 2 && str.Substring(1, 2) == "yt")
        {
           
            return str.Remove(1, 2);
        }
        else
        {
          
            return str;
        }
    }
}
