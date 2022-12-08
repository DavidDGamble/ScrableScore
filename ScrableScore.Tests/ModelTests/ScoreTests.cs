using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ScrableScore.Models;

namespace ScrableScore.Test
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void SplitWord_SplitsWordIntoList_CharArray()
    {
      char[] expected = new char[] { 't', 'e', 's', 't' };
      Score testScore = new Score();
      CollectionAssert.AreEqual(expected, testScore.SplitWord("test"));
    }

    [TestMethod]
    public void valueScore_CalculatesScoreForString_int()
    {
      char[] test = new char[] { 't', 'e', 's', 't' };
      Score testScore = new Score();
      int score = 4;
      Assert.AreEqual(score, testScore.valueScore(test));
    }
  }
}