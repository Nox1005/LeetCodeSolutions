using System;

namespace _01._Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string bestOf = string.Empty;   
            for (int i = 0; i < s.Length; i++)
            {
                string word = string.Empty;
                char current = s[i];
                word += current;
                for (global::System.Int32 j = i + 1; j < s.Length; j++)
                {
                    char current2 = s[j];
                    if (word.Contains(current2))
                    {
                        break;
                    }
                    else
                    {
                        word += current2;
                    }
                }
                if (word.Length > bestOf.Length)
                {
                    bestOf = word;
                    word = string.Empty;
                }
            }
            Console.WriteLine(bestOf.Length);
        }
    }
}
