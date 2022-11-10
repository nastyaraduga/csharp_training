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
    public class ApplicationManager
    {

        /// <summary>
        ///  Присвоение хелперам значения для использования в автотестах
        /// </summary>
        /// 
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;


        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;


        public ApplicationManager()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = "C:\\Program Files\\Mozilla Firefox\\firefox.exe"; //location where Firefox is installed
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost";

            loginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);

        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }
        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }

        }
        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }

        }
        public ContactHelper Contacts
        {
            get
            {
                return contactHelper;
            }
        }

        /// <summary>
        ///  Завершение автотеста
        /// </summary>

        public void Stop()
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
}
