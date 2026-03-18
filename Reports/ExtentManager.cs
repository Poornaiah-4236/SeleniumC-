using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMehendra.Reports
{
    public class ExtentManager
    {
        private static ExtentReports extent;
        public static ExtentReports GetInstance()
        {
           // string reportPath = "Reports/Report_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".html";
            string reportPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "Report_"+DateTime.Now.ToString("yyyyMMddHHmmss") + ".html");
            Console.WriteLine("Report Path : "+reportPath);
            if (extent == null)
            {   var htmlReporter = new ExtentSparkReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", Environment.OSVersion.ToString());
                extent.AddSystemInfo("Machine Name", Environment.MachineName);
                extent.AddSystemInfo("User", Environment.UserName);
                extent.AddSystemInfo("Browser", "Chrome");
                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("Tester", "Poornaiah");              

            }
            return extent;
        }
    }

}
