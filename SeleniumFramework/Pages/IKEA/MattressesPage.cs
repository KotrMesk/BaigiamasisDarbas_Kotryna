
using OpenQA.Selenium.Support.UI;
using System;

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

        public static void ClosePopupWindow()
        {
            string locator = "//*[@class='close-legend' and @aria-label='Close']";
            Common.ClickElement(locator);
        }

        public static void ClickShoppingCartButton()
        {
            throw new NotImplementedException();
        }

        public static string GetItemNumberInItemPage()
        {
            throw new NotImplementedException();
        }

        public static string GetItemNumberInShoppingCart()
        {
            throw new NotImplementedException();
        }

        public static void AcceptCookies()
        {
            string locator = "//*[@id='CybotCookiebotDialogBodyLevelButtonAccept']";
            Common.ClickElement(locator);
        }
    }
}
