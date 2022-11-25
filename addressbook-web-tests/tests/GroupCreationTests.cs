using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
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

