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

        [Test]
        public void GroupCreationTest()
        {
            navigator.OpenHomePage();
            loginHelper.Login(new AccountData ("admin","secret"));
            navigator.GoToGroupsPage();
            groupHelper.InitGroupCreation();
            groupHelper.FillGroupForm(new GroupData("test"));
            groupHelper.SubmitGroupCreation();
            groupHelper.ReturnToMainPage();
        }
    }
}
