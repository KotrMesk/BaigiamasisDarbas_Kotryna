using NUnit.Framework;
using SeleniumFramework.Pages.IKEA;
using SeleniumTests.BaseTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Tests.IKEA
{
    internal class ItemBehaviourInShoppingCartScenario : BaseTest
    {
        [Test]
        public void ItemAddToShoppingCartThroughItemsPage()
        {
            MattressesPage.Open();
            MattressesPage.AcceptCookies();
            MattressesPage.SelectFirstItem();
            MattressesPage.GetItemNumberInItemPage();
            string expectedResult = MattressesPage.GetItemNumberInItemPage();
            MattressesPage.ClickButtonAddToCart();
            MattressesPage.ClosePopupWindow();
            MattressesPage.ClickShoppingCartButton();
            string actualResult = MattressesPage.GetItemNumberInShoppingCart();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void ItemDeleteFromShoppingCart()
        {
            string expectedResult = "Jūsų pirkinių krepšelis tuščias. Jūs neturite prekių pirkinių krepšelyje.";

            MattressesPage.Open();
            MattressesPage.AcceptCookies();
            MattressesPage.UnderFirstItemClickQuickLookButton();
            MattressesPage.ClickButtonInFrameAddToCart();
            MattressesPage.OpenShoppingCartThroughPopupWindow();
            MattressesPage.DeleteItemFromShoppingCart();
            string actualResult = MattressesPage.GetTextOutput();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
