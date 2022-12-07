﻿using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {

        /// <summary>
        /// Удаление группы в адресной книге
        /// </summary>

        [Test]
        public void GroupRemovalTest()
        {
            /// Метод возвращающий список групп на странице до создания новой группы
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove(0);
            /// Метод возвращающий список групп на странице после создания новой группы
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups,newGroups);
        }
    }
}
