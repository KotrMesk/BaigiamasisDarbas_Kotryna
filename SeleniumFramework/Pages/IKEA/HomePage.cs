namespace SeleniumFramework.Pages.IKEA
{
    public class HomePage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.ikea.lt");
        }

        public static void AcceptCookies()
        {
            string locator = "//*[@id='CybotCookiebotDialogBodyLevelButtonAccept']";
            Common.ClickElement(locator);
        }
    }
}
