using System;
using System.Linq;

public class Example
{
    public static string remover(string str)
    {
        int lid = str.LastIndexOf('(');
        if (lid == -1)
        {
            return str;
        }
        else
        {
            int rid = str.IndexOf(')', lid);
            return remover(
                str.Substring(0, lid) +
                new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray()) +
                str.Substring(rid + 1)
            );
        }
    }
    public static void Main()
    {
        Console.WriteLine(remover("p(rq)st"));
        Console.WriteLine(remover("(p(rq)st)"));
        Console.WriteLine(remover("ab(cd(ef)gh)ij"));
    }        
}
