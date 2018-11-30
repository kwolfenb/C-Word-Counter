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
  }
}