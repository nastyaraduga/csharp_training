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

            /// Метод возвращающий список групп на странице до создания новой группы
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Contacts.Remove(1);
            /// Метод возвращающий список групп на странице после создания новой группы
            List<GroupData> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);

        }
    }
}
