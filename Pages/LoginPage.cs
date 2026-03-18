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
    }
 }
    
