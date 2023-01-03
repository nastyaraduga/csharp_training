using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        /// <summary>
        /// Редактирование группы в адресной книге
        /// </summary>

        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("Группа 3");
            newData.Header = null;
            newData.Footer = null;

            /// Метод возвращающий список групп на странице до создания новой группы
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData oldData = oldGroups[0];

            app.Groups.Modify(0, newData);

            //Операция быстро возвращающая количество групп
            Assert.AreEqual(oldGroups.Count, app.Groups.GetGroupCount());

            /// Метод возвращающий список групп на странице после создания новой группы
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
            
            foreach (GroupData group in newGroups)
            {
                if (group.Id == oldData.Id)
                {
                    Assert.AreEqual(newData.Name, group.Name);
                }
            }
        }
    }
}