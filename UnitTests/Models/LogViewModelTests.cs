using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Collections.Generic;

namespace UnitTests.Models
{
    [TestClass]
    public class LogViewModelTests
    {
        [TestMethod]
        public void LogViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange


            // Act
            var result = new LogViewModel();

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void LogViewModel_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new LogViewModel();

            // Act
            var result = myTest.LogList;

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void LogViewModel_Set_Default_Should_Pass()
        {
            // Arrange
            var myTest = new LogViewModel();
            List<LogModel> logModels = new List<LogModel> { new LogModel { PhoneID = "phone-1" } };

            // Act
            myTest.LogList = logModels;
            var result = myTest.LogList;

            // Assert
            Assert.AreEqual("phone-1", result[0].PhoneID);

        }



    }
}
