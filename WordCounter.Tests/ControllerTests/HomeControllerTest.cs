using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      HomeController newHomeController = new HomeController();

      //Act
      ActionResult indexView = newHomeController.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_WordList()
    {
      //Arrange
      ViewResult indexView = new HomeController().Index() as ViewResult;

      //Act
      ViewResult result = (ViewResult) indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<WordSentence>));
    }



  }
}