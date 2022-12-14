using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            // подготовка данных 
            app.Auth.Logout();

            //проверка авторизации
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);
            // верификация 
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }
        [Test]
        public void LoginWithInValidCredentials()
        {
            // подготовка данных 
            app.Auth.Logout();

            //проверка авторизации
            AccountData account = new AccountData("admin", "123456");
            app.Auth.Login(account);
            // верификация 
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }
    }
}
