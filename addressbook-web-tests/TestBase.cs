using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        protected FillContactForm fillContactForm;

        [SetUp]
        /// <summary>
        ///  Присвоение хелперам значения для использования в автотестах
        /// </summary>
        public void SetupTest()
        {

            {
                FirefoxOptions options = new FirefoxOptions();
                options.BrowserExecutableLocation = ("C:\\Program Files\\Mozilla Firefox\\firefox.exe"); //location where Firefox is installed
                driver = new FirefoxDriver(options);
                baseURL = "http://localhost";
                verificationErrors = new StringBuilder();
                loginHelper = new LoginHelper(driver);
                navigator = new NavigationHelper(driver, baseURL);
                groupHelper = new GroupHelper(driver);
                contactHelper = new ContactHelper(driver);
                fillContactForm = new FillContactForm();
            }
        }
        /// <summary>
        ///  Завершение автотеста
        /// </summary>
        /// 
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
    }

    public class FillContactForm
    {
    }
}

