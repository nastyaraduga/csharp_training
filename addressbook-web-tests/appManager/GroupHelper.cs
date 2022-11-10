using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase

    {

        public GroupHelper(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        ///  Клик на "New group" для открытия окна создания группы
        /// </summary>
        public void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        /// <summary>
        ///  Ввод данных в поля на странице создания группы 
        /// </summary>

        public void FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            driver.FindElement(By.Name("submit")).Click();
        }
        /// <summary>
        ///  Возврат на страницу группы
        /// </summary>

        public void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        /// <summary>
        ///  Клик на кнопку "delete groups" для удаления группы
        /// </summary>

        public void RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }
        /// <summary>
        ///  Создание группы по клику на "Enter information"
        /// </summary>
        public void SubmitGroupCreation()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        /// <summary>
        ///  Возврат на стартовую главную страницу, без регистрации
        /// </summary>
        public void ReturnToMainPage()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
        /// <summary>
        ///  Выбор группы из списка 
        /// </summary>
        public void SelectGroup(int index)
        {
            // driver.FindElement(By.XPath("//form[@action='/addressbook/group.php']")).Click();
            driver.FindElement(By.XPath("(//input[@name ='selected[]'])[" + index + "]")).Click();
        }
    }
}
