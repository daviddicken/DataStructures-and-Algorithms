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

      // Hashmap(dictionary) chars in input word
      Dictionary<char, int> wordDict = new Dictionary<char, int>();
      foreach(char letter in word)
      {
        if (!wordDict.TryAdd(letter, 1))
        {
          wordDict[letter] = wordDict[letter] + 1;
        }
      }

      bool flag;  // flag to be false as soon as word is not a anagram
      foreach(string w in words) 
      {
        flag = true;
        Dictionary<char, int> tempDict = new Dictionary<char, int>();
        foreach (char letter in w) // create a new dictionary with word to be checked as anagram
        {
          if (wordDict.ContainsKey(letter)) // exit if letter doesn't exist in orignal word
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
        // if dictionaries are different sizes then word is not a anagram
        if (wordDict.Count != tempDict.Count) flag = false; 
        if (flag)
        {
          //check that each letter appears the same amount of times in each word
          foreach (char letter in w) 
          {
            if(wordDict[letter] != tempDict[letter])
            {
              flag = false;
              break;
            }
          }
          if (flag) //It's an anagram add it to the list
          {
            rtnList.Add(w);
          }
        }
      }
      return rtnList;
    }
  }
}
