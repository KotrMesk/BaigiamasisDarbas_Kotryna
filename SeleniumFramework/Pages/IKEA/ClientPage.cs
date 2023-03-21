namespace SeleniumFramework.Pages.IKEA
{
    public class ClientPage
    {
        private static string inputEmail = "//*[@name='loginForm_email']";

        public static void Open()
        {
            Driver.OpenUrl("https://www.ikea.lt/lt/client");
        }

        public static void EnterEmail(string email)
        {
            Common.SendKeys(inputEmail, email);
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

        public static string GetEmailInputBorderColor()
        {
            return Common.GetElementCssAttributeValue(inputEmail, "border-color");
        }

        public static string GetEmailValidationMessage()
        {
            return Common.GetElementText("//*[@class='message']");
        }

        public static void WaitForEmailInputBorderColorToBe(string expectedColor)
        {
            Common.WaitForElementCssPropertyToBe(inputEmail, "border-color", expectedColor);
        }
    }
}
