using BDTPoM.Pages;
using BDTPoM.Utility;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDTPoM.TestCases
{
    [TestFixture]
    public class BrowseTC : BaseTest
    {

        String TestCaseName = "BDT Login";

        [Test]
        public void openBrowser()
        {

            test = extent.StartTest(TestCaseName);
            Setup("Chrome");

            LaunchingPage l = new LaunchingPage(driver,test);

            PageFactory.InitElements(driver, l);
            l.OpenApplication();

            //LandingPage la = l.OpenApplication();
            //PageFactory.InitElements(driver, la);
            
            //HomePage hp =  la.Login();
            //PageFactory.InitElements(driver, hp);
            //hp.Packages();
            //hp.courses();

        }

        public void EndTest()
        {
            extent.EndTest(test);
            extent.Flush();
            extent.Close();

        }
    }
}
