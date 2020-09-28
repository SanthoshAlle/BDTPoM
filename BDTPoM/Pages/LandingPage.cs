using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BDTPoM.Pages
{
    public class LandingPage : BasePage
    {
        public LandingPage (IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.ClassName, Using = "Login")]
        public IWebElement Loginbutton;


        [FindsBy(How = How.ClassName, Using = "signInPassword")]
        public IWebElement password;


        //check value for username

        [FindsBy(How = How.ClassName, Using = "signInUsername")]
        public IWebElement username;

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

            HomePage hp = new HomePage(driver);
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
