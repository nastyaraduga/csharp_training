using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactInformationTests : AuthTestBase
    {
        [Test]
        public void TestContactInformation()
        {
            //Получаем информацию об одном определенном контакте, который возвращает объект ContactData
            //ContactData fromTable = app.Contacts.GetContactInformationFromTable(0);
            //ContactData fromForm = app.Contacts.GetContactInformationFromEditForm(0);

            //Assert.AreEqual(fromForm, fromTable);
            //Assert.AreEqual(fromTable.Address, fromForm.Address);
            //Assert.AreEqual(fromTable.AllPhones, fromForm.AllPhones);
            //Assert.AreEqual(fromTable.AllEmails, fromForm.AllEmails);
        }
    }
}
