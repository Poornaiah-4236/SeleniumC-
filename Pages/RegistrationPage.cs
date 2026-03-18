using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TechMehendra.Pages
{
    internal class RegistrationPage
    {
        private IWebDriver _driver;
        public By register =By.XPath("//a[normalize-space()='Register']");
        public By firstName =By.XPath("//input[@id='customer.firstName']");
        public By lastName = By.XPath("//input[@id='customer.lastName']");
        public By address =By.XPath("//input[@id='customer.address.street']");
        public By city =By.XPath("//input[@id='customer.address.city']");
        public By state =By.XPath("//input[@id='customer.address.state']");
        public By zip =By.XPath("//input[@id='customer.address.zipCode']");
        public By phone =By.XPath("//input[@id='customer.phoneNumber']");
        public By ssn =By.XPath("//input[@id='customer.ssn']");

        public By useName =By.XPath("//input[@id='customer.username']");
        public By password =By.XPath("//input[@id='customer.password']");
        public By confirmPassword =By.XPath("//input[@id='repeatedPassword']");
        public By registredButton =By.XPath("//input[@value='Register']");
        public By Product =By.XPath("//ul[@class='leftmenu']//a[normalize-space()='Products']");
        public RegistrationPage(IWebDriver driver) { 
            this._driver = driver;
        }
       
        public void EnterText(By locator,string value) {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

          wait.Until(d =>
            {
                try
                {
                    var el = d.FindElement(locator);
                    el.SendKeys(value);
                    return el.Displayed ? el : null;
                }
                catch
                {
                    return null;
                }
            });
            
        }
        public void RegisterUser(string fName, string lName, string addr,
        string cityName, string stateName, string zipCode,
        string phoneNum, string ssnNum, string user,
        string pass, string confirmPass)
        {
            /*
            Register.Click();
            Wait(firstName).SendKeys(fName);
            Wait(lastName).SendKeys(lName);
            Wait(address).SendKeys(addr);
            Wait(city).SendKeys(cityName);
            Wait(state).SendKeys(stateName);
            Wait(zip).SendKeys(zipCode);
            Wait(phone).SendKeys(phoneNum);
            Wait(ssn).SendKeys(ssnNum);
            Wait(useName).SendKeys(user);
            Wait(password).SendKeys(pass);
            Wait(confirmPassword).SendKeys(confirmPass);
            Wait(registredButton).Click();
            WaitForElement(Product,60);
            */


        }
        public IWebElement Wait(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            return wait.Until(d => element.Displayed ? element : null);
        }
        public void WaitForElement(IWebElement element,int time)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
            wait.Until(d => element.Displayed ? element : null);
        }

    }
}
    