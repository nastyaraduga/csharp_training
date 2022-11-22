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
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {

        /// <summary>
        ///  Удаление контакта
        /// </summary>

        [Test]
        public void TheUntitledTestCaseTest()
        {
            ContactData contact = new ContactData("Петров", "Петр");
            app.Contacts.Create(contact);
            app.Contacts.Remove(1);

        }
    }
}
