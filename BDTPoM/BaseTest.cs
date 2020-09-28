using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using BDTPoM.Utility;
using System.Diagnostics.Eventing.Reader;

namespace BDTPoM
{
    public class BaseTest : BasePage
    {
        Public ExtentReports extent = ExtentManager.getInstance();

        public void Setup(string browser)
        {

            test.log(LogStatus.Info, "Chrome should be opened");


            if (browser == "Chrome")
            {

                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                
            }
            else if (browser == "Mozilla")
            {
                driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();
            }

            
        }
    }
}
