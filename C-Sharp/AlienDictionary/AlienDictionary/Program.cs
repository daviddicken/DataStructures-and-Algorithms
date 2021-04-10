using System;

namespace AlienDictionary
{
  public class Program
  {
    static void Main(string[] args)
    {
      string[] inputArr = new string[] { "hell", "hello" };
      string order = "hlabcdefgijkmnopqrstuvwxyz";

      Console.WriteLine(IsAlienSorted(inputArr, order));


    }
    public static bool IsAlienSorted(string[] words, string order)
    {

      for (int i = 0; i < words.Length - 1; i++)
      {
        string word1 = words[i];
        string word2 = words[i + 1];
        int j = 0;
        while (order.IndexOf(word2[j]) == order.IndexOf(word1[j]))
        {
          j++;
          if (j == word2.Length && j < word1.Length) return false;
          if (j == word2.Length && j == word1.Length) break;
          if (j < word2.Length && j == word1.Length) break;
        }
        if(j < word1.Length && j < word2.Length)
        {
          int first = order.IndexOf(word1[j]);
          int second = order.IndexOf(word2[j]);
          if (first > second) return false;

        }
      }
      return true;
    }

  }
}
