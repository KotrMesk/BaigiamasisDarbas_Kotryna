using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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

        internal static void SlideLowPriceHandleToTheRight(string locator)
        {
            IWebElement element = GetElement(locator);

            Actions actions = new Actions(Driver.GetDriver());
            actions.DragAndDropToOffset(element, 150, 0);

            actions.Perform();
        }

        internal static void ScrollDownToSeePrices()
        {
            Actions actions = new Actions(Driver.GetDriver());
            actions.ScrollByAmount(0, 400);
            actions.Perform();
        }

        internal static bool CompareSortedItemsPricesToNewSliderValue()
        {
            string locator = "//*[@class='itemNormalPrice display-6']";
            string prices = GetElement(locator).Text;
            int pricesnew = Int32.Parse(prices.Replace(" €", ""));
            string locator1 = "//*[@id='pmin-pmin']";
            string compare = GetElement(locator1).Text.Substring(12, 3);
            int newLowValue = Int32.Parse(compare);
            if (pricesnew >= newLowValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static void WaitForElementToBeInvisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(locator)));
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(locator)));
        }
    }
}
