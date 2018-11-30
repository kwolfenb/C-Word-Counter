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
    public void WordCounter_ReturnsCorrectView_True()
    {
      //Arrange
      WordCounterController newWordCounterController = new WordCounterController();

      //Act
      ActionResult wordCounterView = newWordCounterController.Index();

      //Assert
      Assert.IsInstanceOfType(wordCounterView, typeof(ViewResult));
    }
  }
}