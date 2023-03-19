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
            //string expectedResult = MattressesPage.GetItemNumberInItemPage();

            MattressesPage.Open();
            MattressesPage.AcceptCookies();
            MattressesPage.SelectFirstItem();
            MattressesPage.ClickButtonAddToCart();
            MattressesPage.ClosePopupWindow();
            MattressesPage.ClickShoppingCartButton();
            string actualResult = MattressesPage.GetItemNumberInShoppingCart();

            //Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
