using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string input = "foo(bar(baz))blim";
        string result = ReverseParentheses(input);
        Console.WriteLine(result);  // Output: "foobazrabblim"
    }

    static string ReverseParentheses(string s)
    {
        Stack<StringBuilder> stack = new Stack<StringBuilder>();
        StringBuilder current = new StringBuilder();

        foreach (char c in s)
        {
            if (c == '(')
            {
                stack.Push(current);
                current = new StringBuilder();
            }
            else if (c == ')')
            {
                current = Reverse(current);
                if (stack.Count > 0)
                {
                    StringBuilder previous = stack.Pop();
                    previous.Append(current);
                    current = previous;
                }
            }
            else
            {
                current.Append(c);
            }
        }

        return current.ToString();
    }

    static StringBuilder Reverse(StringBuilder sb)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            reversed.Append(sb[i]);
        }
        return reversed;
    }
}
