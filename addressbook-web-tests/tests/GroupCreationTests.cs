using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        /// <summary>
        /// Создание группы в адресной книге
        /// </summary>

        [Test]
        public void GroupCreationTest()
        {

            app.Navigator.GoToGroupsPage();
            app.Groups
                .InitGroupCreation()
                .FillGroupForm(new GroupData("test"))
                .SubmitGroupCreation()
                .ReturnToMainPage();
        }
    }
}
