
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Net.NetworkInformation;

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

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }
        internal static void ScrollToElement(int x, int y)
        {
            Actions actions = new Actions(Driver.GetDriver());
            actions.ScrollByAmount(x, y);
            actions.Perform();
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static string GetElementCssAttributeValue(string locator, string cssPropertyName)
        {
            return GetElement(locator).GetCssValue(cssPropertyName);
        }

        internal static void WaitForElementCssPropertyToBe(string locator, string cssProperty, string expectedColor)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)).GetCssValue(cssProperty) == expectedColor);
        }
    }
}
