using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "PhP";
        string returnString = string.Empty;
        int indexOfP = Math.Min(
            str.IndexOf('P') != -1 ? str.IndexOf('P') : int.MaxValue,
            str.IndexOf('p') != -1 ? str.IndexOf('p') : int.MaxValue
        );
        int indexOfH = Math.Min(
            str.IndexOf('H') != -1 ? str.IndexOf('H') : int.MaxValue,
            str.IndexOf('h') != -1 ? str.IndexOf('h') : int.MaxValue
        );

        if ((indexOfP == 0 && indexOfH == 1) || (indexOfH == 0 && indexOfP == 1))
        {
            returnString = str.Substring(0, 2); 
        }
        
        Console.WriteLine(returnString);
    }
}
