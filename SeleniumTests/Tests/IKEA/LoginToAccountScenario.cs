using NUnit.Framework;
using SeleniumFramework.Pages.IKEA;
using SeleniumTests.BaseTests;

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
            ClientPage.WaitForEmailInputBorderColorToBe(expectedEmailBoxColor);
            
            string actualEmailBoxColor = ClientPage.GetEmailInputBorderColor();
            string actualEmailValidationMessage = ClientPage.GetEmailValidationMessage();

            Assert.AreEqual(actualEmailBoxColor, expectedEmailBoxColor);
            Assert.AreEqual(actualEmailValidationMessage, expectedEmailValidationMessage);
        }
    }
}
