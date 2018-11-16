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
      WordSentence newWordSentence = new WordSentence("test", "test");
      Assert.AreEqual(typeof(WordSentence), newWordSentence.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      string wordInput = "coffee";
      WordSentence newWordSentence = new WordSentence("coffee", "test");
      string result = newWordSentence.GetWord();
      Assert.AreEqual(wordInput, result);
    }

    [TestMethod]
    public void GetSentence_ReturnSentence_String()
    {
      string sentenceInput = "I like coffee.";
      WordSentence newWordSentence = new WordSentence("test", "I like coffee.");
      string result = newWordSentence.GetSentence();
      Assert.AreEqual(sentenceInput, result);
    }

    [TestMethod]
    public void SetWord_InputStringWord_String()
    {
      string oldWordInput = "coffee";
      WordSentence newWordSentence = new WordSentence(oldWordInput, "test");

      string newWord = "car";
      newWordSentence.SetWord(newWord);
      string result = newWordSentence.GetWord();
      Assert.AreEqual(newWord, result);
    }

    [TestMethod]
    public void SetSentence_InputStringSentence_String()
    {
      string oldSentenceInput = "I like coffee.";
      WordSentence newWordSentence = new WordSentence("test", oldSentenceInput);

      string newSentence = "My car is a fast car.";
      newWordSentence.SetSentence(newSentence);
      string result = newWordSentence.GetSentence();
      Assert.AreEqual(newSentence, result);
    }

  }

  [TestClass]
  public class RepeatCounterTests
  {

    [TestMethod]
    public void WordInSentence_WordNotInSentence_0()
    {
      //Arrange
      WordSentence newWordSentence = new WordSentence("tea", "I like coffee");
      string wordInput = newWordSentence.GetWord();
      string sentenceInput = newWordSentence.GetSentence();
      RepeatCounter newRepeatCounter = new RepeatCounter(wordInput, sentenceInput);
      //Act
      int result = newRepeatCounter.WordInSentence();

      //Assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void WordInSentence_WordInSentence_1()
    {
      //Arrange
      WordSentence newWordSentence = new WordSentence("coffee", "I like coffee");
      string wordInput = newWordSentence.GetWord();
      string sentenceInput = newWordSentence.GetSentence();
      RepeatCounter newRepeatCounter = new RepeatCounter(wordInput, sentenceInput);

      //Act
      int result = newRepeatCounter.WordInSentence();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordInSentence_CountWordsInSentence_Int()
    {
      //Arrange
      WordSentence newWordSentence = new WordSentence("car", "My car is faster than your car");
      string wordInput = newWordSentence.GetWord();
      string sentenceInput = newWordSentence.GetSentence();
      RepeatCounter newRepeatCounter = new RepeatCounter(wordInput, sentenceInput);

      //Act
      int result = newRepeatCounter.WordInSentence();

      //Assert
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void WordInSentence_CountsWordsByPunctuation_Int()
    {
      //Arrange
      WordSentence newWordSentence = new WordSentence("hungry", "Are you Hungry??");
      string wordInput = newWordSentence.GetWord();
      string sentenceInput = newWordSentence.GetSentence();
      RepeatCounter newRepeatCounter = new RepeatCounter(wordInput, sentenceInput);

      //Act
      int result = newRepeatCounter.WordInSentence();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordInSentence_DoNotCountWordsContainedInWords_Int()
    {
      //Arrange
      WordSentence newWordSentence = new WordSentence("read", "Are you ready??");
      string wordInput = newWordSentence.GetWord();
      string sentenceInput = newWordSentence.GetSentence();
      RepeatCounter newRepeatCounter = new RepeatCounter(wordInput, sentenceInput);

      //Act
      int result = newRepeatCounter.WordInSentence();

      //Assert
      Assert.AreEqual(0, result);
    }

  }
}
