namespace SeleniumFramework.Pages.IKEA
{
    public class BusinessInquiryPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.ikea.lt/lt/business/inquiry");
        }

        public static void EnterWrongRepresentativeName(string name)
        {
            string locator = "//*[@name='representative_name']";
            Common.SendKeys(locator, name);
        }

        public static void EnterRepresentativeSurname(string surname)
        {
            string locator = "//*[@name='representative_surname']";
            Common.SendKeys(locator, surname);
        }

        public static void EnterCompanyName(string companyName)
        {
            string locator = "//*[@name='company_name']";
            Common.SendKeys(locator, companyName);
        }

        public static void EnterEmail(string email)
        {
            string locator = "//*[@name='email']";
            Common.SendKeys(locator, email);
        }

        public static void EnterPhone(string phone)
        {
            string locator = "//*[@name='phone']";
            Common.SendKeys(locator, phone);
        }

        public static void EnterRequest(string request)
        {
            string locator = "//*[@id='root']/div[4]/div/textarea";
            Common.SendKeys(locator, request);
        }

        public static void CheckBoxAgreeToTermsAndConditionsAndPrivacyPolicy()
        {
            string locator = "//*[@id='agree_terms']";
            Common.ClickElement(locator);
        }

        public static void ClickSubmitButton()
        {
            string locator = "//*[@class='btn btn-blue-link']";
            Common.ClickElement(locator);
            Common.WaitForElementToNotExist("//*[@class='busy-load-container']");
        }

        public static string GetWrongRepresentativeNameResult()
        {
            return Common.GetElementText("//*[@class='error-message']");
        }
    }
}
