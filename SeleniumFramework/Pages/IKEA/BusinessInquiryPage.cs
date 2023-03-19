

using System;
using System.Xml.Linq;

namespace SeleniumFramework.Pages.IKEA
{
    public class BusinessInquiryPage
    {
        public static void CheckBoxAgreeToTermsAndConditionsAndPrivacyPolicy()
        {
            throw new NotImplementedException();
        }

        public static void ClickSubmitButton()
        {
            throw new NotImplementedException();
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

        public static void InputRepresentativeSurname(string surname)
        {
            string locator = "//*[@name='representative_surname']";
            Common.SendKeys(locator, surname);
        }

        public static void InputRequest(string request)
        {
            string locator = "//*[@id='root']/div[4]/div/textarea";
            Common.SendKeys(locator, request);
        }

        public static void InputWrongRepresentativeName(string name)
        {
            string locator = "//*[@name='representative_name']";
            Common.SendKeys(locator, name);
        }

        public static void Open()
        {
            Driver.OpenUrl("https://www.ikea.lt/lt/business/inquiry");
        }
    }
}
