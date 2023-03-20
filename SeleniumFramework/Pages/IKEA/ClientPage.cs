using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeleniumFramework.Pages.IKEA
{
    public class ClientPage
    {
        private static string boxToChangeColorLocator = "//*[@name='loginForm_email']";
        public static void Open()
        {
            Driver.OpenUrl("https://www.ikea.lt/lt/client");
        }

        public static void InputWrongEmail(string email)
        {
            string locator = "//*[@name='loginForm_email']";
            Common.SendKeys(locator, email);
        }

        public static void InputPassword(string password)
        {
            string locator = "//*[@name='loginForm_password']";
            Common.SendKeys(locator, password);
        }

        public static void ClickLoginButton()
        {
            string locator = "//*[@id='btnSubmitLogin']";
            Common.ClickElement(locator);
        }

        public static string GetWrongEmailBoxBorderColor()
        {
            return Common.GetElementCssAttributeValue(boxToChangeColorLocator, "border-color");
        }

        public static string GetWrongEmailMessage()
        {
            return Common.GetElementText("//*[@class='message']");
        }

        public static void WaitForEmailBoxBorderColorToBe(string expectedColor)
        {
            Common.WaitForElementCssPropertyToBe(boxToChangeColorLocator, "border-color", expectedColor);
        }
    }
}
