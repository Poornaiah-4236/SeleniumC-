using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
namespace TechMehendra.Pages
{
    internal class ProductsPage
    {
        private IWebDriver driver;
        public By userName = By.XPath("//input[@name='username']");
        public By password = By.XPath("//input[@name='password']");
        public By btnLogin = By.XPath("//input[@value='Log In']");
        public By product = By.XPath("//ul[@class='leftmenu']//a[normalize-space()='Products']");

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;

        }
        public void EnterUserName(string text)
        {
            WaitForElement(userName, 30).SendKeys(text);
        }
        public void EnterPassword(string text)
        {
            WaitForElement(password, 30).SendKeys(text);

        }
        public void ClickLogin()
        {
            WaitForElement(btnLogin, 30).Click();
        }
        public void ClickOnBurtton(By locater,string name)
        {
            IWebElement element=WaitForElement(locater, 30);
            try {
                element.Click();
            } catch (Exception e) { 
                
            }
            
        }
        public void EnterText(By locater, string name)
        {
            WaitForElement(locater, 30).SendKeys(name);
        }
        private IWebElement WaitForElement(By locator, int time)
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
       
        
       

    }
}
    