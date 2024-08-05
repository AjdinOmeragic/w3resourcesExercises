using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str; 
        Console.WriteLine("Enter String:");
        str = Console.ReadLine();
        int ctr = 0;

        for(int i = 0; i < str.Length; i++){
            if(str[i] == 'w'){
                ctr++;
            }
        }

        bool hasConsecutiveWW = false;
        for(int i = 0; i < str.Length - 1; i++){
            if (str.Substring(i, 2).Equals("ww"))
            {
                hasConsecutiveWW = true;
                break;
            }
        }

        if (hasConsecutiveWW && ctr > 2)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }
}
