using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using TechMehendra.Pages;
using TechMehendra.Reports;
namespace TechMehendra.Tests
{
    [TestFixture]
    [TestFixture,Order(1)]
    internal class ValidateLoginTest : BaseTests
    {
        private  ExtentReports extent;
        public  ExtentTest test;
        [SetUp]
        public void setUpReport()
        {
            extent = ExtentManager.GetInstance();
            test = extent.CreateTest("Login Page");

        }

        [Test]
        [TestCase("Poornaiah", "Password@123")]
        public void ValidateLogin(string userName, string password) {

            // Arrange
            Console.WriteLine("Driver NULL? " + (driver == null));
            LoginPage loginPage = new LoginPage(driver);
            // Act
           // loginPage.Login(userName, password);
            EnterText(loginPage.userName, userName,"UserName");
            test.Info(userName +  " Entered Successfully");
            EnterText(loginPage.password, password, "Password");
            test.Info(password + " Entered Successfully");
            ClickOnButton(loginPage.btnLogin, "LoginButton");
            string error=GetText(loginPage.errorMessage);              
            test.Info(error + " Verified");
            test.Equals(error);
            test.Pass("Login page validated Successfully");                 
           

        }        
      
    }
  }

