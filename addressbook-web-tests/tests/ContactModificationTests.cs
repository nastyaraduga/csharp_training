using NUnit.Framework;
using System.Collections.Generic;
using System.Security.Cryptography;

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

            ContactData newContact = new ContactData("Изменили", "Автотестом");

         /*   /// Метод возвращающий список групп на странице до создания нового контакта
            List<ContactData> oldContacts = app.Contacts.GetContactList();
            ContactData contactData = oldContacts[1];
            ContactData oldData = contactData; */

            app.Contacts.Modify(1, newContact);

            /*//Операция быстро возвращающая количество контактов
            Assert.AreEqual(oldContacts.Count, app.Contacts.GetContactCount());

            /// Метод возвращающий список контактов на странице после создания нового контакта
            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].FirstName = newContact.FirstName;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

            foreach (ContactData contact in newContacts)
            {
                if (contact.FirstName == oldData.FirstName)
                {
                    Assert.AreEqual(newContact.FirstName, contact.FirstName);
                }
            }*/

             newContact.FirstName = "Изменили";
             newContact.LastName = "Автотестич";
        }
    }

}
