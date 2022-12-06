using NUnit.Framework;

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
            app.Groups.Create(group);
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
            app.Groups.Create(group);
        }
    }
}

