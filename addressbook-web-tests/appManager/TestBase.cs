using NUnit.Framework;

namespace WebAddressbookTests
{
    /// <summary>
    ///  Создаёт application manager
    /// </summary>
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupApplicationManager()
        {
            app = ApplicationManager.GetInstance();

        }

    }
}