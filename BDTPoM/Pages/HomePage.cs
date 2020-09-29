using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDTPoM.Pages
{
    public class HomePage : BasePage
    {  
        public HomePage (IWebDriver driver, ExtentTest test)
        {
            this.driver = driver;
            this.test = test;
        }

    [FindsBy(How = How.LinkText, Using = "Packages")]
    public IWebElement packages;

    [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/button[1]")]
    public IWebElement popup;

        [FindsBy(How = How.LinkText, Using = "cours")]
        public IWebElement courses;

        public void Packages()
        {
            Thread.Sleep(3000);
            popup.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            packages.Click();
        }
         public void Courses()
        {

            Thread.Sleep(3000);
            popup.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            courses.Click();

        }
        public void webinars()
        {
        }
    
    }


}
