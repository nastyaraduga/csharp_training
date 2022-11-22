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
    public class ContactCreationTests : AuthTestBase
    {
        /// <summary>
        /// Создание контакта в адресной книге
        /// </summary>
        [Test]
        public void ContactCreationTest()
        {

            ContactData contact = new ContactData("Петров","Петр");
            app.Contacts.Create(contact);
            app.Groups.ReturnToMainPage();
        }
    }

}
