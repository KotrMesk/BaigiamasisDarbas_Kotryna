using NUnit.Framework;
using SeleniumFramework.Pages.IKEA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.IKEA
{
    internal class ItemFilterByPriceScenario : BaseTest
    {
        [Test]
        public void MaximumPriceInSliderAdjustment()
        {
            TapsPage.Open();
            TapsPage.SelectFilters();
            TapsPage.SelectPriceFilter();
            TapsPage.SlideLowPriceHandleToTheRight();
            TapsPage.ClickPriceFilter();
            TapsPage.ScrollDownToSeePrices();

            Assert.True(TapsPage.CompareSortedItemsPricesToNewSliderValue());
        }
    }
}
