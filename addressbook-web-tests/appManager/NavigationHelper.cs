using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {

        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }

        /// <summary>
        ///  Открыть главную страницу http://http://localhost/addressbook
        /// </summary>

        public void OpenHomePage()
        {
            if (driver.Url == baseURL + "/addressbook/")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }

        /// <summary>
        ///  Если открыта страница http://localhost/addressbook/
        ///  то ничего не нужно делать
        /// </summary>

        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.LinkText("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
        /// <summary>
        ///  Если открыта страница http://localhost/addressbook/edit.php
        ///  то ничего не нужно делать
        /// </summary>
        public void SelectAddContact()
        {
            if (driver.Url == baseURL + "/addressbook/edit.php"
                && IsElementPresent(By.LinkText("First name")))
            {
                return;
            }
            driver.FindElement(By.LinkText("add new")).Click();
        }
    }
}
