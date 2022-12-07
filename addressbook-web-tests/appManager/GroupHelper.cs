using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase

    {

        public GroupHelper(ApplicationManager manager) : base(manager)
        {
        }
        /// <summary>
        ///  Шаги по созданию группы для автотеста
        /// </summary>
        public GroupHelper Create(GroupData group)
        {
            manager.Navigator.GoToGroupsPage();

            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToMainPage();
            return this;
        }
        /// <summary>
        ///  Шаги по удалению группы для автотеста
        /// </summary>
        public GroupHelper Remove(int v)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(v);
            RemoveGroup();
            ReturnToGroupsPage();
            ReturnToMainPage();
            return this;
        }

        /// <summary>
        ///  Шаги по изменению группы для автотеста
        /// </summary>
        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(v);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnToGroupsPage();
            ReturnToMainPage();
            return this;
        }

        /// <summary>
        ///  Клик на "New group" для открытия окна создания группы
        /// </summary>
        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        /// <summary>
        ///  Ввод данных в поля на странице создания группы 
        /// </summary>

        public GroupHelper FillGroupForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }
        /// <summary>
        ///  Возврат на страницу группы
        /// </summary>

        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }
        /// <summary>
        ///  Клик на кнопку "delete groups" для удаления группы
        /// </summary>

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }
        /// <summary>
        ///  Создание группы по клику на "Enter information"
        /// </summary>
        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        /// <summary>
        ///  Возврат на стартовую главную страницу, без регистрации
        /// </summary>
        public GroupHelper ReturnToMainPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }
        /// <summary>
        ///  Выбор группы из списка 
        /// </summary>
        public GroupHelper SelectGroup(int index)

        {
            // driver.FindElement(By.XPath("//form[@action='/addressbook/group.php']")).Click();
            driver.FindElement(By.XPath("(//input[@name ='selected[]'])[" + index + "]")).Click();
            return this;
        }
        /// <summary>
        ///  Клик на кнопу update
        /// </summary>
        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
        /// <summary>
        ///  Клик на кнопку edit
        /// </summary>
        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public List<GroupData> GetGroupList()
        {
            //Добавляем пустой список групп
            List<GroupData> groups = new List<GroupData>();
            manager.Navigator.GoToGroupsPage();
            //сохраняем найденные элементы группы в переменную
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));

            //Для каждого элемента в коллекции нужно выполнить действие
            foreach (IWebElement element in elements)
            {
                groups.Add(new GroupData(element.Text));
            }    
            return groups;
        }
    }
}
