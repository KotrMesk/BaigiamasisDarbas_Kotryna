

using System;
using System.Xml.Linq;

namespace SeleniumFramework.Pages.IKEA
{
    public class BusinessInquiryPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.ikea.lt/lt/business/inquiry");
        }

        public static void InputWrongRepresentativeName(string name)
        {
            string locator = "//*[@name='representative_name']";
            Common.SendKeys(locator, name);
        }

        public static void InputRepresentativeSurname(string surname)
        {
            string locator = "//*[@name='representative_surname']";
            Common.SendKeys(locator, surname);
        }

        public static void InputCompanyName(string companyName)
        {
            string locator = "//*[@name='company_name']";
            Common.SendKeys(locator, companyName);
        }

        public static void InputEmail(string email)
        {
            string locator = "//*[@name='email']";
            Common.SendKeys(locator, email);
        }

        public static void InputPhone(string phone)
        {
            string locator = "//*[@name='phone']";
            Common.SendKeys(locator, phone);
        }

        public static void InputRequest(string request)
        {
            string locator = "//*[@id='root']/div[4]/div/textarea";
            Common.SendKeys(locator, request);
        }

        public static void CheckBoxAgreeToTermsAndConditionsAndPrivacyPolicy()
        {
            string locator = "//*[@id='agree_terms']";
            Common.ScrollToElement(0, 250);
            Common.ClickElement(locator);
        }

        public static void ClickSubmitButton()
        {
            string locator = "//*[@class='btn btn-blue-link']";
            Common.ClickElement(locator);
        }

        public static string GetWrongRepresentativeNameResult()
        {
            Common.ScrollToElement(0, -300);
            return Common.GetElementText("//*[@class='error-message']");
        }
    }
}
