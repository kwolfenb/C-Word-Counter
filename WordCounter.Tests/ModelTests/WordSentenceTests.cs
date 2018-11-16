using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests

{
  [TestClass]
  public class WordSentenceTests
  {
    [TestMethod]
    public void WordSentenceConstructor_CreatesInstanceOfItem_Item()
    {
      WordSentence newWordSentence = new WordSentence("test");
      Assert.AreEqual(typeof(WordSentence), newWordSentence.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      string wordInput = "coffee";
      WordSentence newWordSentence = new WordSentence("coffee");
      string result = newWordSentence.GetWord();
      Assert.AreEqual(wordInput, result);
    }
  }

}