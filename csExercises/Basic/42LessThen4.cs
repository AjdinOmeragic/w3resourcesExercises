using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string str;
       str = Console.ReadLine();
       if(str.Length < 3){
           Console.WriteLine(str.ToUpper());
       } else if (str.Length <= 4) {
           Console.WriteLine(str.ToLower());
       } else {
           Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4));
       }
    }
}
