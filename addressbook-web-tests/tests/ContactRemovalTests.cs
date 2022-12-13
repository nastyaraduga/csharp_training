using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {

        /// <summary>
        ///  Удаление контакта
        /// </summary>

        [Test]
        public void ContactRemovalTest()
        {
            ContactData contact = new ContactData("Петров");
            app.Contacts.Create(contact);
            app.Contacts.Remove(1);
        }
    }
}