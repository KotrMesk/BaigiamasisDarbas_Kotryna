using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
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

        internal static void SwitchToDialog()
        {
            Driver.GetDriver().SwitchTo().Equals(false);
        }

        internal static void SwitchToSideNavigation()
        {
            Driver.GetDriver().FindElement(By.XPath("//*[@id='sidenav']"));
        }

        internal static string GetElementTextPart(string locator)
        {
            return GetElement(locator).Text.Substring(14, 10);
        }

        internal static void WaitForElementAndClick(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
            GetElement(locator).Click();
        }

        internal static void DragAndDropToOffset(string locator, int offsetX, int offsetY)
        {
            IWebElement element = GetElement(locator);

            Actions actions = new Actions(Driver.GetDriver());
            actions.DragAndDropToOffset(element, offsetX, offsetY);
            actions.Perform();
        }

        internal static List<string> GetTextOfMultipleElements()
        {
            List<IWebElement> elements = GetElements("//*[contains(@class,'itemNormalPrice')]");
            List<string> texts = new List<string>();

            foreach (IWebElement element in elements)
            {
                texts.Add(element.Text);
            }

            return texts;
        }

        internal static void WaitForElementToNotExist(string locator)
        {
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    GetElement(locator);
                    System.Threading.Thread.Sleep(50);
                }
                catch (NoSuchElementException)
                {
                    return;
                }
            }
        }
    }
}
