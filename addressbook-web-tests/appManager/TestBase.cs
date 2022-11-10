using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
        public void SetupTest()
        {
            app = new ApplicationManager();
        }

        /// <summary>
        ///  Завершение application manager
        /// </summary>
        public void TearDownTest()
        {
            app.Stop();
        }
    }
}