using NUnit.Framework;

namespace WebAddressbookTests
{
    // Базовый класс для авторизации 
    public class AuthTestBase : TestBase
    {

        [SetUp]
        public void SetupLogin()
        {
            app.Auth.Login(new AccountData("admin", "secret"));
        }
    }
}
