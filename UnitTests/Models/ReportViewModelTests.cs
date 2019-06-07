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
        public void ReportViewModel_Get_NumberOfUsers_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            var result = myTest.NumberOfUsers;

            // Assert
            Assert.IsNotNull(myTest.NumberOfUsers);
        }

        [TestMethod]
        public void ReportViewModel_Set_NumberOfUsers_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            myTest.NumberOfUsers = 1;
            var result = myTest.NumberOfUsers;

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ReportViewModel_Get_LogViewModel_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            var result = myTest.LogViewModel;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_Set_LogViewModel_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();
            // Need a LogViewModel different from the default
            LogViewModel logViewModel = new LogViewModel();
            logViewModel.LogList.Add(new LogModel(){ PhoneID = "NikePhone+" });

            // Act
            myTest.LogViewModel = logViewModel;
            var result = myTest.LogViewModel.LogList;

            // Assert
            Assert.AreEqual("NikePhone+", result[0].PhoneID);
        }
    }
}
