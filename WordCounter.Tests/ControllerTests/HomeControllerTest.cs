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

  }
}