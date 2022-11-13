using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
    {
        [TestFixture]
        public class GroupModificationTests : TestBase
        {
             /// <summary>
            /// Редактирование группы в адресной книге
            /// </summary>

            [Test]
            public void GroupModificationTest()
             {
            GroupData newData = new GroupData("Группа 1");
            newData.Header = "Хеддер";
            newData.Footer = "Футер";
            app.Groups.Modify(1, newData);
            }
        }
    }