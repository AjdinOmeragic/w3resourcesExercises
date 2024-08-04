using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str;
        Console.WriteLine("Enter String with at least one w");
        str = Console.ReadLine();
        
        if(str.Contains("w")){
            Console.WriteLine("The String Contains it");
            
        } else{
            Console.WriteLine("The String doesnt have it");
            
        }
        
    }
}
