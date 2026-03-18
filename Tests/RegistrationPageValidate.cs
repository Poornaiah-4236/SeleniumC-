using AventStack.ExtentReports;
using NUnit.Framework;
using TechMehendra.Pages;
using TechMehendra.Reports;
namespace TechMehendra.Tests
{
    [TestFixture]
    [TestFixture,Order(2)]
    public class RegistrationPageValidate : BaseTests
    {
        private  ExtentReports extent;
        private ExtentTest test;
        [SetUp]
        public void setUpReport()
        {
            extent = ExtentManager.GetInstance();
            test = extent.CreateTest("Registration Page");

        }

        [Test]
        [TestCase("Poornaiah",
            "Madipalli",
            "Rampally",
            "Hyderabad",
            "Telangana",
            "501301",
            "9790810869",
            "123498765",
            "Darshan",
            "Password@123",
            "Password@123")]
        public void ValidateRegisterUser(string fName, string lName, string addr,
        string cityName, string stateName, string zipCode,
        string phoneNum, string ssnNum, string user,
        string pass, string confirmPass)
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            ClickOnButton(regPage.register, "Register");           
            EnterText(regPage.firstName, fName,"FirstNamw");
            EnterText(regPage.lastName, lName, "LastName");
            EnterText(regPage.address, addr, "Address");
            EnterText(regPage.city, cityName, "City");
            EnterText(regPage.state, stateName, "State");
            EnterText(regPage.zip, zipCode, "ZIP");
            EnterText(regPage.phone, phoneNum, "Phone");
            EnterText(regPage.ssn, ssnNum, "SSN");
            EnterText(regPage.useName, user, "User");
            EnterText(regPage.password, user, "Password");
            EnterText(regPage.confirmPassword, pass, "Password");
            ClickOnButton(regPage.registredButton, "Register");
            test.Pass("User Successfully Registred");
        }
        
    }
}
