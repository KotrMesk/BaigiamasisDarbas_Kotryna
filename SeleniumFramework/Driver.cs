using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;


namespace SeleniumFramework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        public static void SetupDriver()
        {
            ChromeOptions options = new ChromeOptions();
            driver.Value = new ChromeDriver(options);
            options.AddArgument("--disable-infobars");
            options.AddExcludedArgument("enable-automation");
            options.AddExcludedArgument("excludeSwitches");
        }
        public static void CloseDriver()
        {
            driver.Value.Quit();
        }

        public static string TakeScreenshot(string methodName)
        {
            string screenshotDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
            string screenshotFilePath = $"{screenshotDirectoryPath}\\{screenshotName}.png";

            Directory.CreateDirectory(screenshotDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
            return screenshotFilePath;
        }

        internal static void OpenUrl(string url)
        {
            driver.Value.Url = url;
        }
        public static IWebDriver GetDriver()
        {
            return driver.Value;
        }
    }
}
