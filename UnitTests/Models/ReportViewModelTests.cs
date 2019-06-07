using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange

            // Act
            var myTest = new ReportViewModel();

            // Assert
            Assert.IsNotNull(myTest);
        }

        [TestMethod]
        public void ReportViewModel_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            var result = myTest.NumberOfUsers;

            // Assert
            Assert.IsNotNull(myTest.NumberOfUsers);
        }

        [TestMethod]
        public void ReportViewModel_Set_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            myTest.NumberOfUsers = 1;
            var result = myTest.NumberOfUsers;

            // Assert
            Assert.AreEqual(1, result);
        }

    }
}
