using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RelevantCodes.ExtentReports;

namespace BDTPoM.Pages
{
    public class LandingPage : BasePage
    {
        public LandingPage(IWebDriver driver, ExtentTest test)
        {
            this.driver = driver;
            this.test = test;
        }
        [FindsBy(How = How.LinkText, Using = "Login")]
        public IWebElement Loginbutton;
       

        [FindsBy(How = How.ClassName, Using = "signInUsername")]
        public IWebElement username;

        [FindsBy(How = How.ClassName, Using = "signInPassword")]
        public IWebElement password;


    

        public HomePage Login()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            Loginbutton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            username.SendKeys("isantha@live.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            password.SendKeys("Dotnet");
            password.SendKeys(Keys.Enter);

            HomePage hp = new HomePage(driver, test);
            PageFactory.InitElements(driver, hp);
            return hp;
        }
        public void GmailLogin()
        {
        }
        public void FacebookLogin()
        {
        }


    }
}
