using NUnit.Framework;
using SeleniumFramework.Pages.IKEA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.IKEA
{
    internal class ItemBehaviourInShoppingCartScenario : BaseTest
    {
        [Test]
        public void ItemAddToShoppingCartThroughItemsPage()
        {
            MattressesPage.Open();
            MattressesPage.SelectFirstItem();
            string expectedResult = MattressesPage.GetItemNumberInItemPage();
            MattressesPage.ClickButtonAddToCart();
            MattressesPage.CloseDialogWindow();
            MattressesPage.ClickShoppingCartButton();
            string actualResult = MattressesPage.GetItemNumberInShoppingCart();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ItemDeleteFromShoppingCart()
        {
            string expectedResult = "Jūsų pirkinių krepšelis tuščias. Jūs neturite prekių pirkinių krepšelyje.";

            MattressesPage.Open();
            MattressesPage.UnderFirstItemClickQuickLookButton();
            MattressesPage.ClickButtonInSideNavigationAddToCart();
            MattressesPage.OpenShoppingCartThroughDialogWindow();
            MattressesPage.DeleteItemFromShoppingCart();
            string actualResult = MattressesPage.GetTextOutput();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
