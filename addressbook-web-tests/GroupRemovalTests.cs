﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests 
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
            navigator.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToGroupsPage();
            groupHelper.SelectGroup(1);
            groupHelper.RemoveGroup();
            groupHelper.ReturnToGroupsPage();
        }
    }
}
