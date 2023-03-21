using System.Runtime.CompilerServices;
namespace SeleniumFramework.Pages.IKEA
{
    public class MattressesPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.ikea.lt/lt/rooms/miegamasis/ciuziniai-ir-ju-priedai/ciuziniai");
        }

        public static void SelectFirstItem()
        {
            string locator = "//h3[ text() = 'VESTERÖY' ][1]";
            Common.ClickElement(locator);
        }

        public static void ClickButtonAddToCart()
        {
            string locator = "//*[@class='shopping-cart-buy']";
            Common.ClickElement(locator);
        }

        public static void CloseDialogWindow()
        {

            string locator = "//*[@data-action='close']";
            Common.WaitForElementToBeVisisble("//*[@class='modal fade show']");
            Common.ClickElement(locator);

        }

        public static void ClickShoppingCartButton()
        {
            string locator = "//*[@id='headerMainToggler']//*[@class='cart full empty']";
            Common.ClickElement(locator);
        }

        public static string GetItemNumberInItemPage()
        {
            return Common.GetElementTextPart("//*[@class='partNumber']");
        }

        public static string GetItemNumberInShoppingCart()
        {
            return Common.GetElementText("//*[@class='partnumber']");
        }

        public static void AcceptCookies()
        {
            string locator = "//*[@id='CybotCookiebotDialogBodyLevelButtonAccept']";
            Common.ClickElement(locator);
        }

        public static void UnderFirstItemClickQuickLookButton()
        {
            string locator = "//*[@data-item='00450502']";
            Common.ClickElement(locator);
        }

        public static void ClickButtonInSideNavigationAddToCart()
        {
            string locator = "//*[@class='shopping-cart-buy']";
            Common.WaitForElementAndClick(locator);
            Common.WaitForElementToBeVisisble("//*[@class='modal fade show']");
        }

        public static void OpenShoppingCartThroughDialogWindow()
        {
            string locator = "//*[@data-action='goCart']";
            // Brain started melting, could not find a proper way to wait
            System.Threading.Thread.Sleep(1000);
            Common.WaitForElementAndClick(locator);
        }

        public static void DeleteItemFromShoppingCart()
        {
            string locator = "//*[@class='iconPos-bin icon-bind']";
            Common.ClickElement(locator);
        }

        public static string GetTextOutput()
        {
            return Common.GetElementText("//*[@class='m-3']");
        }
    }
}
