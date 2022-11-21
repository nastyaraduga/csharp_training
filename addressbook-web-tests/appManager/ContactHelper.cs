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
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("lastname"), contact.Lastname);
            return this;
        }

        /// <summary>
        ///  Шаги по созданию контакта для автотеста
        /// </summary>
        public ContactHelper Modify(int v, ContactData newContact)
        {
            manager.Navigator.OpenHomePage();
            SelectContact(v);
            GoToEditContact();
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

            public ContactHelper GoToEditContact()
            {
                driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
                return this;
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
                driver.FindElement(By.LinkText("Logout")).Click();
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
            driver.FindElement(By.Id("2")).Click();
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

    }
 }