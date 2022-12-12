using NUnit.Framework;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {

        /// <summary>
        /// Создание группы с текстовым именем, лого и комментарием
        /// </summary>

        [Test]
        public void GroupCreationTest()
        {

            GroupData group = new GroupData("test");
            group.Header = "test1";
            group.Footer = "test2";
            /// Метод возвращающий список групп на странице до создания новой группы
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);
            /// Метод возвращающий список групп на странице после создания новой группы
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups,newGroups);
        }

        /// <summary>
        /// Создание группы с пустым именем, лого и комментарием
        /// </summary>
        [Test]
        public void EmptyGroupCreationTest()
        {

            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
        [Test]
        //Автотест на проверку бага при создании группы. Группа не создается с символом '
        public void BadGroupCreationTest()
        {

            GroupData group = new GroupData("'a");
            group.Header = "test1";
            group.Footer = "test2";
            /// Метод возвращающий список групп на странице до создания новой группы
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);
            /// Метод возвращающий список групп на странице после создания новой группы
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}

