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
            TapsPage.TogglePriceFilter();
            TapsPage.SlideLowPriceHandleAboveSpecifiedValue(60);
            TapsPage.SlideHighPriceHandleBelowSpecifiedValue(130);
            int priceLowValue = TapsPage.GetActualPriceFilterLowValue();
            int priceHighValue = TapsPage.GetActualPriceFilterHighValue();
            TapsPage.TogglePriceFilter();

            Assert.True(TapsPage.DisplayedProductPricesAreWithinRange(priceLowValue, priceHighValue));
        }
    }
}
