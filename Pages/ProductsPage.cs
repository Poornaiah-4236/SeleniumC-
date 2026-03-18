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
       

    }
}
    
