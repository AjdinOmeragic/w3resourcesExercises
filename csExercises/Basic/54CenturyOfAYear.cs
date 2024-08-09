using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(centuryFromYear(1799) == 18);
        Console.WriteLine(centuryFromYear(1899) == 18);
        Console.WriteLine(centuryFromYear(1499) == 15);
    }
    public static int centuryFromYear(int year){
        return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
    }
    
}
