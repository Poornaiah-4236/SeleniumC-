using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechMehendra.Reports;
using TechMehendra.Utilities;
namespace TechMehendra
{
    [TestFixture]
    public class BaseTests
    {
       public IWebDriver driver;
        protected string URL = "https://parabank.parasoft.com";
        protected string browser ="chrome";
        private  ExtentReports extent;
        private  ExtentTest test;
        [OneTimeSetUp]
        public void setUpReport() {
            extent=ExtentManager.GetInstance();
            test = extent.CreateTest("BaseTests");
            
        }
        [SetUp]
        public void setUp() {
           
            driver = DriverFactory.GetWebDriver(browser);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl(URL);
            test.Pass("URL launched successfully");
        }

        public void EnterText(By locator,string value,string name) {
            IWebElement element =WaitForElement(locator,30);
            try
            {
                if (value != null)
                {
                    element.SendKeys(value);
                    test.Info(value + " Entered into " + name);
                }
                else {
                    test.Warning(" Please enter text into text box " + name);
                }                
            }catch(Exception ex) {
                test.Fail(ex.Message);
            }
        }
        public void EnterText(IWebElement locator, string value, string name)
        {
            IWebElement element = WaitForElement(locator, 30);
            try
            {
                if (value != null)
                {
                    element.SendKeys(value);
                    test.Info(value + " Entered into " + name);
                }
                else
                {
                    test.Warning(" Please enter text into text box " + name);
                }
            }
            catch (Exception ex)
            {
                test.Fail(ex.Message);
            }
        }
        public void ClickOnButton(By locator,string name) {
            IWebElement element =WaitForElement(locator,30);
            try
            {
                if (element.Displayed)
                {
                    element.Click();
                    test.Info(" User Clicked on  " + name);
                }
                else {
                    test.Warning(" Element Not displaying " + name);
                }                
            }catch(Exception ex) {
                test.Fail(ex.Message);
            }
        }
        public String GetText(By locator)
        {
            IWebElement element = WaitForElement(locator, 30);
            return element.Text;

        }
        [TearDown] 
        public void tearDown() {          
            driver.Dispose();
            driver.Quit();

        }
        [OneTimeTearDown]
        public void OneTimeTearDown() { 
            extent.Flush();
            
        }
        public IWebElement WaitForElement(By locator, int time)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));

            return wait.Until(d =>
            {
                try
                {
                    var el = d.FindElement(locator);
                    return el.Displayed ? el : null;
                }
                catch
                {
                    return null;
                }
            });
        }
        public IWebElement WaitForElement(IWebElement element, int time)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));

            return wait.Until(d =>
            {
                try
                {                   
                    return element.Displayed ? element : null;
                }
                catch
                {
                    return null;
                }
            });
        }


    }
}
