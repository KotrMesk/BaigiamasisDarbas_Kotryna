using NUnit.Framework;
using SeleniumFramework.Pages.IKEA;
using SeleniumTests.BaseTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Tests.IKEA
{
    internal class LoginToAccountScenario : BaseTest
    {
        [Test]
        public void LoginToAccountWithInvalidEmail()
        {
            string expectedEmailBoxColor = "rgb(204, 0, 0)";
            string expectedEmailValidationMessage = "Invalid email";

            string email = "elpastas";
            string password = "slaptazodis";
            
            ClientPage.Open();
            ClientPage.EnterEmail(email);
            ClientPage.EnterPassword(password);
            ClientPage.ClickLoginButton();
            ClientPage.WaitForEmailBoxBorderColorToBe(expectedEmailBoxColor);
            
            string actualEmailBoxColor = ClientPage.GetEmailBoxBorderColor();
            string actualEmailValidationMessage = ClientPage.GetEmailValidationMessage();

            Assert.AreEqual(actualEmailBoxColor, expectedEmailBoxColor);
            Assert.AreEqual(actualEmailValidationMessage, expectedEmailValidationMessage);
        }

    }
}
