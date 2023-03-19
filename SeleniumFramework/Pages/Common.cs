
using OpenQA.Selenium;
using System;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }
        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }
    }
}
