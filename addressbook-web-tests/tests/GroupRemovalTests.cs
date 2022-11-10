using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using addressbook_web_tests.appManager;
using NUnit.Framework;

namespace addressbook_web_tests.tests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {

        /// <summary>
        /// Удаление группы в адресной книге
        /// </summary>

        [Test]
        public void GroupRemovalTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.SelectGroup(1);
            app.Groups.RemoveGroup();
            app.Groups.ReturnToGroupsPage();
        }
    }
}
