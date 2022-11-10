﻿using System;
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
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.InitGroupCreation();
            app.Groups.FillGroupForm(new GroupData("test"));
            app.Groups.SubmitGroupCreation();
            app.Groups.ReturnToMainPage();
        }
    }
}
