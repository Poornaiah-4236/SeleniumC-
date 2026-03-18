using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMehendra.Utilities
{
    public class DriverFactory
    {
        public static IWebDriver GetWebDriver(string browser) {
            switch (browser) {
                case "chrome":
                    return new ChromeDriver();
                case "edge":
                    return new EdgeDriver();
                case "firefox":
                    return new FirefoxDriver();
                default:
                    return new ChromeDriver();

            }
        }
    }
}
