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
        public void LoginToAccountWithWrongEmail()
        {
            string expectedWrongEmailBoxColor = "rgb(204, 0, 0)";
            string expectedWrongEmailMessage = "Invalid email";

            string email = "elpastas";
            string password = "slaptazodis";
            
            ClientPage.Open();
            ClientPage.InputWrongEmail(email);
            ClientPage.InputPassword(password);
            ClientPage.ClickLoginButton();
            ClientPage.WaitForEmailBoxBorderColorToBe(expectedWrongEmailBoxColor);
            
            string actualWrongEmailBoxColor = ClientPage.GetWrongEmailBoxBorderColor();
            string actualWrongEmailMessage = ClientPage.GetWrongEmailMessage();

            Assert.AreEqual(actualWrongEmailBoxColor, expectedWrongEmailBoxColor);
            Assert.AreEqual(actualWrongEmailMessage, expectedWrongEmailMessage);
        }

    }
}
