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
            ContactData newContact = new ContactData("", "");
            newContact.FirstName = "Новый";
            newContact.LastName = "Контакт";
            app.Contacts.Create(newContact);
            app.Contacts.Remove(1);
        }
    }
}