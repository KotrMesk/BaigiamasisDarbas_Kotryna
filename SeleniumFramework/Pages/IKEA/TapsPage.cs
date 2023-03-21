using System;

namespace SeleniumFramework.Pages.IKEA
{
    public class TapsPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.ikea.lt/lt/rooms/vonia/vonios-vandens-maisytuvai");
        }

        public static void SelectFilters()
        {
            Common.ClickElement("//*[@class='filterToggler']");
        }

        public static void SelectPriceFilter()
        {
            Common.ClickElement("//*[@data-id='price']/..");
        }

        public static void SlideLowPriceHandleToTheRight()
        {
            Common.SlideLowPriceHandleToTheRight("//*[@class='pointer low']");
            Common.WaitForElementToBeVisible("//*[@class='busy-load-container']");
            Common.WaitForElementToBeInvisible("//*[@class='busy-load-container']");
        }

        public static void ClickPriceFilter()
        {
            Common.ClickElement("//*[@class='filterToggler']");
        }

        public static void ScrollDownToSeePrices()
        {
            Common.ScrollDownToSeePrices();
        }

        public static bool CompareSortedItemsPricesToNewSliderValue()
        {
            return Common.CompareSortedItemsPricesToNewSliderValue();
        }
    }
}
