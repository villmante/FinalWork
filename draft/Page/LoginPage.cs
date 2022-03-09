using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace FinalWork.Page
{
    public class LoginPage : BasePage
    {

        private const string PageAddress = "https://barbora.lt/";
        private IWebElement _selectCity => Driver.FindElement(By.CssSelector("#regionApp > div.b-region > div > div.container-fluid > div > div > div > div.row > div > div.b-region--search > div > div.col-md-9 > div > div.b-region--search-block-input > input[type=text]"));
        private IWebElement _cityVilnius => Driver.FindElement(By.CssSelector("#regionApp > div.b-region > div > div.container-fluid > div > div > div > div.row > div > div.b-region--search > div > div.col-md-9 > div > div.visible-md-block.visible-lg-block > div > ul > li:nth-child(1)"));
        private IWebElement _continue => Driver.FindElement(By.CssSelector("#regionApp > div.b-region > div > div.container-fluid > div > div > div > div.row > div > div.row > div > button"));
        private IWebElement _login => Driver.FindElement(By.CssSelector("div.b-header--links--item:nth-child(1) > button:nth-child(1) > span:nth-child(2)"));
        private IWebElement _email => Driver.FindElement(By.CssSelector("#email"));
        private IWebElement _password => Driver.FindElement(By.CssSelector("#password"));
        private IWebElement _loginButton => Driver.FindElement(By.CssSelector("#modal-placeholder > div > div.modal.b-alert--modal > div > div > div.modal-body > form > button"));
        private IWebElement _user => Driver.FindElement(By.CssSelector("/html/body/div[2]/div/header/div[1]/div/div/div[2]/div[1]/div/div[1]/div/p"));
        private IWebElement _help => Driver.FindElement(By.CssSelector("body > div.b-app > div > header > div.b-header-top > div > div > div:nth-child(2) > div.b-help-btn--placeholder > button"));

        public LoginPage(IWebDriver webdriver) : base(webdriver)
        { }

        public LoginPage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public void SelectCity()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_selectCity));
            _selectCity.Click();
            _cityVilnius.Click();
            _continue.Click();
        }

        public void Login()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_help));
            _login.Click();
            _email.SendKeys("XXXXX@gmail.com");
            _password.SendKeys("XXXXX");
            _loginButton.Click();
        }

        public void  AssertLoginSuccesse()
        {
            Assert.AreEqual("vilmante", _user.Text, "tekstas nesutampa!");
        }
    }
}


