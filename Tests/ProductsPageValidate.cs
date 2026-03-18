using AventStack.ExtentReports;
using NUnit.Framework;
using TechMehendra.Pages;
using TechMehendra.Reports;
namespace TechMehendra.Tests
{
    [TestFixture]
    [TestFixture, Order(3)]
    public class ProductsPageValidate : BaseTests
    {
        private  ExtentReports extent;
        private  ExtentTest test;
        [SetUp]
        public void setUpReport()
        {
            extent = ExtentManager.GetInstance();
            test = extent.CreateTest("Registration Page");

        }
        [Test]
        [TestCase("Darshan","Password@123")]
        public void validateProduct(string user,string pass)
        {

            ProductsPage prPage = new ProductsPage(driver);
            EnterText(prPage.userName, user,"User");
            EnterText(prPage.password, pass, "Password");
            ClickOnButton(prPage.btnLogin,"Login Button");
            WaitForElement(prPage.product,60);
            ClickOnButton(prPage.product, "Login Button");
            test.Pass("Product page validated successfully");

        }
    }
    
}
