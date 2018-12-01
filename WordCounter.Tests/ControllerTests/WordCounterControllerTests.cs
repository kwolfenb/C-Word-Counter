using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      WordCounterController newWordCounterController = new WordCounterController();

      //Act
      ActionResult wordCounterView = newWordCounterController.Index();

      //Assert
      Assert.IsInstanceOfType(wordCounterView, typeof(ViewResult));
    }

    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      //Arrange
      WordCounterController newWordForm = new WordCounterController();

      //Act
      ActionResult wordFormView = newWordForm.New();

      //Assert
      Assert.IsInstanceOfType(wordFormView, typeof(ViewResult));
    }

    [TestMethod] //Tests Dictionary type in Post method
    public void Show_CreatesTypeDictionary_Dictionary()
    {
      //Arrange
      WordCounterController newResult = new WordCounterController();
      Dictionary<string, object> newModel = new Dictionary<string, object>();
      string newWord = "test";
      string newSentence = "this is a test";
      RepeatCounter newRepeatCounter = new RepeatCounter(newWord, newSentence);
      WordSentence newWordSentence = new WordSentence(newWord, newSentence);

      //Act
      newModel.Add("wordSentence", newWordSentence);
      newModel.Add("repeatCounter", newRepeatCounter);

      //Assert
      Assert.IsInstanceOfType(newModel, typeof(Dictionary<string, object>));

    }
  }
}