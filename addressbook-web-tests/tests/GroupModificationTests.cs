using NUnit.Framework;

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
            GroupData newData = new GroupData("Группа 1");
            newData.Header = null;
            newData.Footer = null;
            app.Groups.Modify(1, newData);
        }
    }
}