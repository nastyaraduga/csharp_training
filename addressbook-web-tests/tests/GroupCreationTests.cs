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

            GroupData group = new GroupData("test");
            group.Header = "test1";
            group.Footer = "test2";
            app.Groups.Create(group);
        }
    }
}

