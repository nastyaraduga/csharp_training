using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using addressbook_web_tests.appManager;

namespace addressbook_web_tests.tests
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
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.SelectAddContact();
            app.Contacts.FillContactForm(new ContactData("test", "test"));
            app.Contacts.SubmitContactCreation();
            app.Groups.ReturnToMainPage();
        }
    }

}
