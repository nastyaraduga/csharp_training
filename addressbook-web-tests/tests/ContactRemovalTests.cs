using NUnit.Framework;

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
            ContactData contact = new ContactData("Петров");
            app.Contacts.Create(contact);
            app.Contacts.Remove(1);

        }
    }
}
