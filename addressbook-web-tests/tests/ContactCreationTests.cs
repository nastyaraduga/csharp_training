using NUnit.Framework;

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

            ContactData contact = new ContactData("Петров", "Петр");
            app.Contacts.Create(contact);
            app.Groups.ReturnToMainPage();
        }
    }

}
