using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TechMehendra.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public By userName = By.XPath("//input[@name='username']");
        public By password = By.XPath("//input[@name='password']");
        public By btnLogin = By.XPath("//input[@value='Log In']");
        public By errorMessage = By.XPath("//p[@class='error']");
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
          
        }

        
       /* public void EnterUserName(string text)
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
        public String GetErrorMessage()
        {
            return WaitForElement(errorMessage, 60).Text;

        }
        public IWebElement WaitforElementDisplayed(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            return wait.Until(d =>
            {
                try
                {
                    IWebElement element = d.FindElement(locator);
                    return element.Displayed ? element : null;
                }
                catch
                {
                    return null;
                }
            });
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
        public void Login(string username, string pwd)
        {
            EnterUserName(username);
            EnterPassword(pwd);
           ClickLogin();
        }
        */
    }
 }
    