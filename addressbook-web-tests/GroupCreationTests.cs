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
            OpenHomePage();
            Login(new AccountData ("admin","secret"));
            GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(new GroupData("test"));
            SubmitGroupCreation();
            ReturnToMainPage();
        }
    }
}
