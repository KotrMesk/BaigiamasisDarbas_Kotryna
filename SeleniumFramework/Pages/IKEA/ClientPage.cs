﻿namespace SeleniumFramework.Pages.IKEA
{
    public class ClientPage
    {
        private static string boxToChangeColorLocator = "//*[@name='loginForm_email']";

        public static void Open()
        {
            Driver.OpenUrl("https://www.ikea.lt/lt/client");
        }

        public static void EnterEmail(string email)
        {
            string locator = "//*[@name='loginForm_email']";
            Common.SendKeys(locator, email);
        }

        public static void EnterPassword(string password)
        {
            string locator = "//*[@name='loginForm_password']";
            Common.SendKeys(locator, password);
        }

        public static void ClickLoginButton()
        {
            string locator = "//*[@id='btnSubmitLogin']";
            Common.ClickElement(locator);
        }

        public static string GetEmailBoxBorderColor()
        {
            return Common.GetElementCssAttributeValue(boxToChangeColorLocator, "border-color");
        }

        public static string GetEmailValidationMessage()
        {
            return Common.GetElementText("//*[@class='message']");
        }

        public static void WaitForEmailBoxBorderColorToBe(string expectedColor)
        {
            Common.WaitForElementCssPropertyToBe(boxToChangeColorLocator, "border-color", expectedColor);
        }
    }
}
