using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        /// <summary>
        /// Создание контакта в адресной книге
        /// </summary>
        [Test]
        public void TheUntitledTestCaseTest()
        {
            navigator.OpenHomePage(); 
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.SelectAddContact();
            contactHelper.FillContactForm(new ContactData("test","test"));
            contactHelper.SubmitContactCreation();
            groupHelper.ReturnToMainPage();
        }
    }

}
