using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager) : base(manager)
        {

        }
        /// <summary>
        ///  Ввод данных в поля логин и пароль
        /// </summary>
        public void Login(AccountData account)
        {
            /// <summary>
            ///  Проверка авторизации в браузере
            /// </summary>
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account))
                {
                    return;
                }
                Logout();
            }

            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }
        public void Logout()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.LinkText("Logout")).Click();
            }
        }
        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn()
                 && driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text
                 == "(" + account.Username + ")";
        }
    }
}
