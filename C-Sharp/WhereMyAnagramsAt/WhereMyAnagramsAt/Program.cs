using System;
using System.Collections.Generic;

namespace WhereMyAnagramsAt
{
  public class Program
  {
    static void Main(string[] args)
    {
      List<string> testInput = new List<string>{ "ab", "aa", "bb", "cc", "ac", "bc", "cd", "ba" };

      List<string> tester = new List<string>();
      tester = Anagrams("ab", testInput);
      foreach(string word in tester)
      {
        Console.Write($"{word}, ");
      }
    }

    public static List<string> Anagrams(string word, List<string> words)
    {
      List<string> rtnList = new List<string> { };

      Dictionary<char, int> wordDict = new Dictionary<char, int>();
      foreach(char letter in word)
      {
        if (!wordDict.TryAdd(letter, 1))
        {
          wordDict[letter] = wordDict[letter] + 1;
        }
      }

      bool flag;
      foreach(string w in words)
      {
        flag = true;
        Dictionary<char, int> tempDict = new Dictionary<char, int>();
        foreach (char letter in w)
        {
          if (wordDict.ContainsKey(letter))
          {
            if (!tempDict.TryAdd(letter, 1))
            {
              tempDict[letter] = tempDict[letter] + 1;
            }
          }
          else
          {
            flag = false;
            break;
          }
        }
        if (wordDict.Count != tempDict.Count) flag = false;
        if (flag)
        {
          foreach(char letter in w)
          {
            if(wordDict[letter] != tempDict[letter])
            {
              flag = false;
              break;
            }
          }
          if (flag)
          {
            rtnList.Add(w);
          }
        }
      }
      return rtnList;
    }
  }
}
