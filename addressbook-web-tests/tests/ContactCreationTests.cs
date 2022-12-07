using NUnit.Framework;
using System.Collections.Generic;
using System.Security.Cryptography;

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

            ContactData contact = new ContactData("Иванов");
            app.Contacts.Create(contact);
        }
    }

}
