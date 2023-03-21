using NUnit.Framework;
using SeleniumFramework.Pages.IKEA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.IKEA
{
    internal class ItemFilterByPriceScenario : BaseTest
    {
        [Test]
        public void MinimumPriceInSliderAdjustment()
        {
            TapsPage.Open();
            TapsPage.SelectPriceFilter();
            TapsPage.SlideLowPriceHandleToTheRight();
            TapsPage.SelectPriceFilter();
            TapsPage.ScrollDownToSeePrices();

            Assert.True(TapsPage.CompareSortedItemsPricesToNewSliderValue());
        }
    }
}
