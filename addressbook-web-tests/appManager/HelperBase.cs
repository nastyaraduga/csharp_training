using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected IWebDriver driver;
        /// <summary>
        ///  Использование драйвера в работе автотеста
        /// </summary>

        public HelperBase(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}