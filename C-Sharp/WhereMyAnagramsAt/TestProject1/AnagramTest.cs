using System;
using Xunit;
using WhereMyAnagramsAt;
using System.Collections.Generic;

namespace TestProject1
{
  public class AnagramTest
  {
    [Fact]
    public void HappyPath()
    {
      string testString = "abba";
      List<string> testInput = new List<string> { "aabb", "abcd", "bbaa", "dada" };
      List<string> expected = new List<string> { "aabb", "bbaa" };

      Assert.Equal(Program.Anagrams(testString, testInput), expected);
    }

    [Fact]
    public void NoAnagrams()
    {
      string testString = "abba";
      List<string> testInput = new List<string> { "abcd", "dada" };
      List<string> expected = new List<string>();

      Assert.Equal(Program.Anagrams(testString, testInput), expected);
    }

    [Fact]
    public void ExtraLetters()
    {
      string testString = "abba";
      List<string> testInput = new List<string> { "abcd", "dada", "abbba" };
      List<string> expected = new List<string>();

      Assert.Equal(Program.Anagrams(testString, testInput), expected);
    }

    [Fact]
    public void EmptyInput()
    {
      string testString = "";
      List<string> testInput = new List<string> { "abcd", "dada", "abbba" };
      List<string> expected = new List<string>();

      Assert.Equal(Program.Anagrams(testString, testInput), expected);
    }
  }
}
