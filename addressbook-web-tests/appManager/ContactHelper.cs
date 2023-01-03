using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V104.Audits;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }

        /// <summary>
        ///  Выбор раздела "add new"
        /// </summary>
        public ContactHelper Create(ContactData contact)
        {
            manager.Navigator.SelectAddContact();
            FillContactForm(contact);
            SubmitContactCreation();
            return this;
        }

        /// <summary>
        /// Клик на кнопку update при создания контакта
        /// </summary>
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }

        /// <summary>
        ///  Добавление в поля ввода данных contact
        /// </summary>

        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.FirstName);
            Type(By.Name("lastname"), contact.LastName);
            return this;
        }

        /// <summary>
        ///  Шаги по созданию контакта для автотеста
        /// </summary>
        public ContactHelper Modify(int v, ContactData newContact)
        {
            manager.Navigator.OpenHomePage();
            SelectContact(v);
            GoToEditContact(0);
            SubmitContactModification(newContact);
            ReturnToMainPage();
            return this;
        }
        /// <summary>
        ///  Шаги по удалению контакта для автотеста
        /// </summary>

        public ContactHelper Remove(int v)
        {
            manager.Navigator.OpenHomePage();
            RemoutContact();
            CloseAlertAndGetItsText(true);
            ReturnToMainPage();
            return this;
        }


        /// <summary>
        ///  Проставление галки в чекбокс контакта
        /// </summary>

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name ='selected[]'])[" + index + "]")).Click();
            return this;
        }
        /// <summary>
        ///  Клик на элемент редактирования контакта
        /// </summary>


        public void GoToEditContact(int index)
        {
            /* var aaa = driver.FindElements(By.Id("maintable"))[0];
             var bbb = aaa.FindElements(By.TagName("tr"))[1];
             var bbb2 = bbb.FindElements(By.TagName("td"))[6];
             var ccc = bbb2.FindElements(By.TagName("a"))[0];
             driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
             // ccc.Click();*/

            driver.FindElements(By.Id("maintable"))[0]
                    .FindElements(By.TagName("tr"))[1]
                    .FindElements(By.TagName("td"))[6]
                    .FindElements(By.TagName("a"))[0]
                    .FindElement(By.XPath("//img[@alt='Edit']")).Click();
        }
        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        /// <summary>
        ///  Возврат стартовую страницу
        /// </summary>

        public ContactHelper ReturnToMainPage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }
        /// <summary>
        ///  Клик на кнопку update при редактировании контакта
        /// </summary>
        public ContactHelper SubmitContactModification(ContactData newContact)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[22]")).Click();
            return this;
        }
        /// <summary>
        ///  Выделение первого контакта и клик на кнопку delete
        /// </summary>
        public ContactHelper RemoutContact()
        {
            driver.FindElement(By.Id("25")).Click();
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }


        /// <summary>
        ///  Alert окно с удалением контакта
        /// </summary>
        public ContactHelper CloseAlertAndGetItsText(bool acceptNextAlert)
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
            }
            finally
            {
            }
            return this;
        }

        public ContactData GetContactInformationFromTable(int index)
        {
            manager.Navigator.OpenHomePage();
            IList<IWebElement> cells = driver.FindElements(By.Id("maintable"))[index]
                .FindElements(By.TagName("td"));
            string lastName = cells[1].Text;
            string firstName = cells[2].Text;
            string address = cells[3].Text;
            string allEmails = cells[4].Text;
            string allPhones = cells[5].Text;

            return new ContactData(firstName, lastName)
            {
                Address = address,
                AllPhones = allPhones,
                AllEmails = allEmails
            };
        }

        public ContactData GetContactInformationFromEditForm(int index)
        {
            manager.Navigator.OpenHomePage();
            GoToEditContact(0);
            string firstName = driver.FindElement(By.Name("firstname")).GetAttribute("value");
            string lastName = driver.FindElement(By.Name("lastname")).GetAttribute("value");
            string address = driver.FindElement(By.Name("address")).GetAttribute("value");

            string homePhone = driver.FindElement(By.Name("home")).GetAttribute("value");
            string mobilePhone = driver.FindElement(By.Name("mobile")).GetAttribute("value");
            string workPhone = driver.FindElement(By.Name("work")).GetAttribute("value");

            string oneEmail = driver.FindElement(By.Name("email")).GetAttribute("value");
            string twoEmail = driver.FindElement(By.Name("email2")).GetAttribute("value");
            string threeEmail = driver.FindElement(By.Name("email3")).GetAttribute("value");

            return new ContactData(firstName, lastName)
            {
                Address = address,
                HomePhone = homePhone,
                MobilePhone = mobilePhone,
                OneEmail = oneEmail,
                TwoEmail = twoEmail,
                ThreeEmail = threeEmail
            };
        }
        private List<ContactData> contactCash = null;

        public List<ContactData> GetContactList()
        {
            if (contactCash == null)
            {
                contactCash = new List<ContactData>();
                manager.Navigator.OpenHomePage();
                //Сохраняем найденные элементы контактов в переменную
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.contact"));

                //Для каждого элемента в коллекции нужно выполнить действие
                foreach (IWebElement element in elements)
                {
                    //Объявляем локальную переменную для объекта 
                    contactCash.Add(new ContactData(element.Text, element.Text)
                    {
                        FirstName = element.FindElement(By.TagName("input")).GetAttribute("value")
                    });
                }
            }
            //Возвращаем свою старую копию версии cash
            return new List<ContactData>(contactCash);
        }
        public int GetContactCount()
        {
            return driver.FindElements(By.CssSelector("span.contact")).Count;
        }

    }
}