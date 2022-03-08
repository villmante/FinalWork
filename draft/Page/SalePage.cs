using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace FinalWork.Page
{
    public class SalePage : BasePage
    {
       private IWebElement _myGoods => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-menu > ul > li:nth-child(2)"));
        private IWebElement _createList => Driver.FindElement(By.CssSelector("#my-favourites--placeholder > div > div.row.b-my-favourites-desktop--wrap > div:nth-child(1) > div > div > div > div > div.content-block.white-bg > div.row.b-horizontal-pages--bottom-content > div:nth-child(1) > button"));
        private IWebElement _nameSpace => Driver.FindElement(By.CssSelector(".b-input-field--root"));
        private IWebElement _nameSpaceActive => Driver.FindElement(By.CssSelector("input.b-text-overflow-ellipsis--text"));
        private IWebElement _create => Driver.FindElement(By.CssSelector("#modal-placeholder > div > div.modal.b-alert--modal > div > div > div.modal-body > form > button > span"));
        private IWebElement _close => Driver.FindElement(By.CssSelector("#modal-placeholder > div > div.modal.b-alert--modal > div > div > div.modal-body > form > button"));
        private IWebElement _listName => Driver.FindElement(By.CssSelector("#my-favourites--placeholder > div > div.row.b-my-favourites-desktop--wrap > div:nth-child(1) > div > div > div > div > div.content-block.white-bg > div:nth-child(1) > div > button.c-btn.c-btn--gray.c-btn--block.b-horizontal-pages--text.b-text-overflow-ellipsis--wrap > span.b-horizontal-pages--text--name.b-text-overflow-ellipsis--text"));
        private IWebElement _listMessge => Driver.FindElement(By.CssSelector("div.b-alert:nth-child(2)"));
        private IWebElement _salePage => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-menu > ul > li:nth-child(3) > a"));
        private IWebElement _selectItem => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-page-specific-content > div.b-products-list--wrapper > div:nth-child(1) > div:nth-child(1) > div.b-product--wrap.clearfix.b-product--js-hook > div.b-product-wrap-img > a.b-product-title.b-product-title--desktop.b-link--product-info"));
        private IWebElement _addToFavorites => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-page-specific-content > div.b-page-container.b-info-page-container > div.b-product-info.b-product--js-hook > div.b-products-allow-desktop-view.b-products-allow-mobile-view > div.row > div:nth-child(2) > div:nth-child(3) > button"));
        private IWebElement _addFavoritesCheckBox => Driver.FindElement(By.CssSelector(".checkbox > label:nth-child(1)"));
        private IWebElement _buttonSave => Driver.FindElement(By.CssSelector("div.col-xs-6:nth-child(2)"));
        private IWebElement _listMsg => Driver.FindElement(By.CssSelector("#customer-data-placeholder > div > div > div.b-customer-data--content.b-text-overflow-ellipsis--wrap > div > div > div > div.b-top-nav-bar > div.b-alert.b-alert--warning"));
        private IWebElement _buttonToCart => Driver.FindElement(By.CssSelector("#customer-data-placeholder > div > div > div.b-customer-data--content.b-text-overflow-ellipsis--wrap > div > div > div > div.b-saved-baskets--cart-wrap.content-block.white-bg > div > div.b-sticker.b-sticker--mobile-only > div > div > div:nth-child(2) > button.c-btn.c-btn--block.b-saved-baskets--add-cart-items"));
        private IWebElement _buttonRermoveList => Driver.FindElement(By.CssSelector("#my-favourites--placeholder > div > div.row.b-my-favourites-desktop--wrap > div:nth-child(1) > div > div > div > div > div.content-block.white-bg > div:nth-child(1) > div > button.c-btn.c-btn--transparent.b-horizontal-pages--delete-btn"));
        private IWebElement _emptyListMsg => Driver.FindElement(By.CssSelector("#my-favourites--placeholder > div > div.row.b-my-favourites-desktop--wrap > div:nth-child(1) > div > div > div > div > div.content-block.white-bg > div.b-alert.b-alert--warning.content-block--item"));
        
        public SalePage(IWebDriver webdriver) : base(webdriver)
        { }

        public void CreateList()
        {
            _myGoods.Click();
            _createList.Click();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_nameSpace));
            _nameSpace.Click();
            _nameSpaceActive.SendKeys("Test");
            _create.Click();
            _close.Click();
            _listName.Click();
        }

        public void RemoveList()
        {
            _myGoods.Click();
            _buttonRermoveList.Click();
        }

        public void AddItemToList()
        {
            _salePage.Click();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_selectItem));
            _selectItem.Click();
            Thread.Sleep(5000);
            wait.Until(ExpectedConditions.ElementToBeClickable(_addToFavorites));
            _addToFavorites.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(_addFavoritesCheckBox));
            _addFavoritesCheckBox.Click();
            _buttonSave.Click();
            _myGoods.Click();
            _listName.Click();
        }

        public void AssertNewList()
        {
            Assert.AreEqual("Kol kas ruošinyje prekių nėra. Norėdami įdėti patikusią prekę, spauskite prie jos esančią širdelę.", _listMessge.Text, "Pranešimo tekstas nesutampa!");
            _myGoods.Click();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_listName));
            Assert.AreEqual("Test", _listName.Text, "Ruošinio pavadinimas nesutampa!");
        }

        public void AsserListErrased()
        {
            _myGoods.Click();
            Assert.AreEqual("Krepšelių ruošinių neturite. Susikūrę dažnai perkamų prekių ruošinius, apsipirksite greičiau.", _emptyListMsg.Text, "Pranešimo tekstas nesutampa!");
        }

        public void AssertItemToList()
        {
            Assert.AreEqual("Ruošinyje yra 1 prekė(s). Norėdami jas įdėti į krepšelį, spauskite „Į krepšelį“. Jei kažkurios prekės dėti nenorite, nuimkite varnelę.", _listMsg.Text, "RPranešimo tekstas nesutampa!");
            Assert.AreEqual("Į krepšelį", _buttonToCart.Text, "Mygtuko pavadinimas nesutampa!");
        }
    }
}


