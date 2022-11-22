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
    public class ContactModificationTests : AuthTestBase
    {
        /// <summary>
        /// Редактирование контакта в адресной книге
        /// </summary>
        [Test]
        public void ContactModificationTest()
        {

            ContactData newContact = new ContactData("Иванов", "Иван");
            newContact.Firstname = "Петр";
            newContact.Lastname = "Петрович";
            app.Contacts.Modify(1, newContact);
        }
    }

}
