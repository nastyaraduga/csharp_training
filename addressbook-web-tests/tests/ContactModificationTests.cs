using NUnit.Framework;

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
