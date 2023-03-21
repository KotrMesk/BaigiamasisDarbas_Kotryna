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
            Common.ClickElement("//*[@class='filterBlock'][1]");
        }

        public static void SlideLowPriceHandleToTheRight()
        {
            Common.SlideLowPriceHandleToTheRight("//*[@class='pointer low']");
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
