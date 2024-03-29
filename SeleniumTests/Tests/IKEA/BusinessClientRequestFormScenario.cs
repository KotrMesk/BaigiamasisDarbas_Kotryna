﻿using NUnit.Framework;
using SeleniumFramework.Pages.IKEA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.IKEA
{
    internal class BusinessClientRequestFormScenario : BaseTest
    {
        [Test]
        public void WrongSymbolsInNameOfRepresentativeLine()
        {
            string name = "456";
            string surname = "Pavarde";
            string companyName = "Imone";
            string phone = "1234567";
            string email = "imone@imone.com";
            string request = "request";

            string expectedResult = $"Lauke negali būti įvesti simboliai '{name[0]}', '{name[1]}', '{name[2]}'";

            BusinessInquiryPage.Open();
            BusinessInquiryPage.EnterWrongRepresentativeName(name);
            BusinessInquiryPage.EnterRepresentativeSurname(surname);
            BusinessInquiryPage.EnterCompanyName(companyName);
            BusinessInquiryPage.EnterEmail(email);
            BusinessInquiryPage.EnterPhone(phone);
            BusinessInquiryPage.EnterRequest(request);
            BusinessInquiryPage.CheckBoxAgreeToTermsAndConditionsAndPrivacyPolicy();
            BusinessInquiryPage.ClickSubmitButton();
            string actualResult = BusinessInquiryPage.GetWrongRepresentativeNameResult();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
