using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using UnitTestingDemo;
using UnitTestingDemo.Controllers;
using UnitTestingDemo.Models;

namespace UnitTestingDemo.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]

        public void TestDetailsViewData()

        {

            var controller = new HomeController();

            var result = controller.DetailProduct(2) as ViewResult;

            var product = (Product)result.ViewData.Model;

            Assert.AreEqual("Lenovo laptop", product.Name);

        }



        [TestMethod]

        public void TestSomeRedirect()

        {

            var controller = new HomeController();

            var result = (RedirectToRouteResult)controller.SomeAction(7);

            Assert.AreEqual("Index", result.RouteValues["action"]);





        }
    }
}
