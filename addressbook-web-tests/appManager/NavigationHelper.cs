using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {

        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }

        /// <summary>
        ///  Открыть главную страницу http://http://localhost/addressbook
        /// </summary>

        public void OpenHomePage()
        {
            if (driver.Url == baseURL + "/addressbook/")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }

        /// <summary>
        ///  Открыть страницу http://localhost/addressbook/group.php
        /// </summary>

        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.LinkText("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
        /// <summary>
        ///  Открыть страницу http://localhost/addressbook/edit.php
        /// </summary>
        public void SelectAddContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
    }
}
