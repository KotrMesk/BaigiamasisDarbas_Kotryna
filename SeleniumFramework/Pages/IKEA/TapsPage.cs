using System;
using System.Collections.Generic;

namespace SeleniumFramework.Pages.IKEA
{
    public class TapsPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.ikea.lt/lt/rooms/vonia/vonios-vandens-maisytuvai");
        }

        public static void TogglePriceFilter()
        {
            Common.ClickElement("//*[@data-id='price']/..");
        }

        public static void SlideLowPriceHandleAboveSpecifiedValue(int specifiedValue)
        {
            string locatorSliderElement = "//*[@data-id='price']//*[contains(@class,'pointer low')]";
            string locatorSliderValue = "//*[@data-id='price']//*[@class='pointer-label low']";

            int actualValue = Convert.ToInt32(Common.GetElementText(locatorSliderValue));
            while (actualValue < specifiedValue)
            {
                Common.DragAndDropToOffset(locatorSliderElement, 20, 0);
                actualValue = Convert.ToInt32(Common.GetElementText(locatorSliderValue));
            }
        }

        public static void SlideHighPriceHandleBelowSpecifiedValue(int specifiedValue)
        {
            string locatorSliderElement = "//*[@data-id='price']//*[contains(@class,'pointer high')]";
            string locatorSliderValue = "//*[@data-id='price']//*[@class='pointer-label high']";

            int actualValue = Convert.ToInt32(Common.GetElementText(locatorSliderValue));
            while (actualValue > specifiedValue)
            {
                Common.DragAndDropToOffset(locatorSliderElement, -20, 0);
                actualValue = Convert.ToInt32(Common.GetElementText(locatorSliderValue));
            }
        }

        public static int GetActualPriceFilterLowValue()
        {
            return Convert.ToInt32(Common.GetElementText("//*[@data-id='price']//*[@class='pointer-label low']"));
        }

        public static int GetActualPriceFilterHighValue()
        {
            return Convert.ToInt32(Common.GetElementText("//*[@data-id='price']//*[@class='pointer-label high']"));
        }

        public static bool DisplayedProductPricesAreWithinRange(int priceLowValue, int priceHighValue)
        {
            List<string> pricesText = Common.GetTextOfMultipleElements();
            List<double> prices = new List<double>();

            foreach (string price in pricesText)
            {
                prices.Add(Convert.ToDouble(price.Remove(price.Length - 1)));
            }

            foreach (double price in prices)
            {
                if (price < priceLowValue || price > priceHighValue)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
