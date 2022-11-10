﻿using System;
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

        [SetUp]
        public void SetupTest()
        {

            {
                FirefoxOptions options = new FirefoxOptions();
                options.BrowserExecutableLocation = ("C:\\Program Files\\Mozilla Firefox\\firefox.exe"); //location where Firefox is installed
                driver = new FirefoxDriver(options);
                baseURL = "http://localhost";
                verificationErrors = new StringBuilder();
            }
        }

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

        protected void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }
        protected void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("pass")).Click();
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        protected void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        protected void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        protected void FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            driver.FindElement(By.Name("submit")).Click();
        }
        protected void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        protected void RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }
        protected void ReturnToMainPage()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        protected void SubmitGroupCreation()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        protected void SelectGroup(int index)
        {
            // driver.FindElement(By.XPath("//form[@action='/addressbook/group.php']")).Click();
            driver.FindElement(By.XPath("(//input[@name ='selected[]'])[" + index + "]")).Click();
        }
    }

}

