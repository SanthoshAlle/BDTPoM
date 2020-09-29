using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BDTPoM.Pages
{
    public class LaunchingPage : BasePage
    {
        public LaunchingPage(IWebDriver driver, ExtentTest test)
        {
            this.driver = driver;
            this.test = test;
        }

        public LandingPage OpenApplication()
        {
            driver.Url = "https://www.bestdotnettraining.com";
            LandingPage lp = new LandingPage(driver, test);
            PageFactory.InitElements(driver, lp);
            return lp;

            
        }


    }
}
