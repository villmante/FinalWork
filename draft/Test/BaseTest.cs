using FinalWork.Drivers;
using FinalWork.Page;
using FinalWork.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace FinalWork.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static HomePage _homePage;
        public static LoginPage _loginPage;
        public static SalePage _salePage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetFirefoxDriver();

            _homePage = new HomePage(driver);
            _loginPage = new LoginPage(driver);
            _salePage = new SalePage(driver);
        }

        [TearDown]
        public static void TakeScreeshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreeshot(driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
        }
    }
}

