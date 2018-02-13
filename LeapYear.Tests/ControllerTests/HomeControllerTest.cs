using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LeapYear.Controllers;
using LeapYear.Models;

namespace LeapYear.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      //Checks if Returns correct View
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
          //Arrange
          HomeController controller = new HomeController();

          //Act
          IActionResult indexView = controller.Index();
          ViewResult result = indexView as ViewResult;

          //Assert
          Assert.IsInstanceOfType(result, typeof(ViewResult));
      }
      //Checks if passes correct Model
      [TestMethod]
      public void Index_HasCorrectModelType()
      {
          //Arrange
          HomeController controller = new HomeController();
          IActionResult actionResult = controller.Index();
          ViewResult indexView = controller.Index() as ViewResult;

          //Act
          var result = indexView.ViewData.Model;

          //Assert
          Assert.IsInstanceOfType(result, typeof(bool));
      }
}
}
