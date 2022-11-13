﻿using System;
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
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("theform")).Click();
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            return this;
        }

        public ContactHelper Modify(int v, ContactData newContact)
        {
            manager.Navigator.OpenHomePage();
            SelectContact(v);
            GoToEditContact();
            SubmitContactModification(newContact);
            ReturnToMainPage();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name ='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public ContactHelper GoToEditContact()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }

        public ContactHelper ReturnToMainPage()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            return this;
        }

        public ContactHelper SubmitContactModification(ContactData newContact)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[22]")).Click();
            return this;
        }
    }
}
