using System;
using System.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string strOriginal = "w3resources";
        StringBuilder strNew = new StringBuilder();
        
        for(int i = 0; i < strOriginal.Length-1; i++){
            if(i % 2 == 0){
                strNew.Append(strOriginal[i]);
            }
        }

        Console.WriteLine("New string: " + strNew.ToString());
    }
}
