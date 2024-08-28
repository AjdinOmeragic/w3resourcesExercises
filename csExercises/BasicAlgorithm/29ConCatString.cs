using System;

class Program
{
    static void Main()
    {
        string[] str = { "Python", "PHP", "JS" };

        foreach (var str in str)
        {
            string result = everyOther(str);
            Console.WriteLine(result);
        }
    }

    static string everyOther(string input)
    {
        string result = "";

        for (int i = 0; i < input.Length; i += 2)
        {
            result += input[i];
        }

        return result;
    }
}
