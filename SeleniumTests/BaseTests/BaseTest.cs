using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SeleniumFramework;
using SeleniumFramework.Pages.IKEA;

namespace SeleniumTests.BaseTests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            HomePage.Open();
            HomePage.AcceptCookies();
        }

        [TearDown]
        public void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string filePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(filePath);
            }
            Driver.CloseDriver();
        }
    }
}
