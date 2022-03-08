using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Globalization;

namespace FinalWork.Page
{
    public class HomePage : BasePage
    {

        private const string PageAddress = "https://barbora.lt/";
        private IWebElement _item1Add => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-page-specific-content > div.b-page-container.b-page-container--home > div:nth-child(2) > div:nth-child(1) > div > section.b-home--products-section.b-display--tablet.b-display--desktop > div > div.b-products-list--wrapper > div.b-products-list.items.clearfix.b-products-allow-desktop-view.b-products-allow-mobile-view.b-products--desktop-grid.b-products-list--contains-product-card-banner > div:nth-child(1) > div.b-product--wrap.clearfix.b-product--js-hook > div.b-product-info-wrap > div > div.b-product-price-cart-link.clearfix > div > div > div.b-next-quantity-select--wrap.b-next-quantity-select--wrap--single > button"));
        private IWebElement _item1Name => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-page-specific-content > div.b-page-container.b-page-container--home > div:nth-child(2) > div:nth-child(1) > div > section.b-home--products-section.b-display--tablet.b-display--desktop > div > div.b-products-list--wrapper > div.b-products-list.items.clearfix.b-products-allow-desktop-view.b-products-allow-mobile-view.b-products--desktop-grid.b-products-list--contains-product-card-banner > div:nth-child(1) > div.b-product--wrap.clearfix.b-product--js-hook > div.b-product-wrap-img > a.b-product-title.b-product-title--desktop.b-link--product-info > span"));
        private IWebElement _item2Add => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-page-specific-content > div.b-page-container.b-page-container--home > div:nth-child(2) > div:nth-child(1) > div > section.b-home--products-section.b-display--tablet.b-display--desktop > div > div.b-products-list--wrapper > div.b-products-list.items.clearfix.b-products-allow-desktop-view.b-products-allow-mobile-view.b-products--desktop-grid.b-products-list--contains-product-card-banner > div:nth-child(2) > div.b-product--wrap.clearfix.b-product--js-hook > div.b-product-info-wrap > div > div.b-product-price-cart-link.clearfix > div > div > div.b-next-quantity-select--wrap.b-next-quantity-select--wrap--single > button"));
        private IWebElement _item1PriceCart => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-sidebar > div > div.b-sidebar--active-cart.b-sidebar--inner > div.b-sidebar--contents > div.b-cart > div.b-scrollBox > div.b-cart--list.b-cart--items.b-scrollable-area > div > div.b-cart--scrollable-blocks-wrap--cart-content > div:nth-child(1) > div > div > div > span"));
        private IWebElement _item2PriceCart => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-sidebar > div > div.b-sidebar--active-cart.b-sidebar--inner > div.b-sidebar--contents > div.b-cart > div.b-scrollBox > div.b-cart--list.b-cart--items.b-scrollable-area > div > div.b-cart--scrollable-blocks-wrap--cart-content > div:nth-child(2) > div > div > div > span"));
        private IWebElement _item3PriceCart => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-sidebar > div > div.b-sidebar--active-cart.b-sidebar--inner > div.b-sidebar--contents > div.b-cart > div.b-scrollBox > div.b-cart--list.b-cart--items.b-scrollable-area > div > div.b-cart--scrollable-blocks-wrap--cart-content > div:nth-child(3) > div > div > div > span"));
        private IWebElement _item3Add => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-page-specific-content > div.b-page-container.b-page-container--home > div:nth-child(2) > div:nth-child(1) > div > section.b-home--products-section.b-display--tablet.b-display--desktop > div > div.b-products-list--wrapper > div.b-products-list.items.clearfix.b-products-allow-desktop-view.b-products-allow-mobile-view.b-products--desktop-grid.b-products-list--contains-product-card-banner > div:nth-child(7) > div.b-product--wrap.clearfix.b-product--js-hook > div.b-product-info-wrap > div > div.b-product-price-cart-link.clearfix > div > div > div.b-next-quantity-select--wrap.b-next-quantity-select--wrap--single > button"));
        private IWebElement _item1NameCart => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-sidebar > div > div.b-sidebar--active-cart.b-sidebar--inner > div.b-sidebar--contents > div.b-cart > div.b-scrollBox > div.b-cart--list.b-cart--items.b-scrollable-area > div > div.b-cart--scrollable-blocks-wrap--cart-content.b-cart--scrollable-blocks-wrap--cart-content--only-item > div > div > div > span > a"));
        private IWebElement _item1Price => Driver.FindElement(By.CssSelector(".b-products-list--contains-product-card-banner > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(2) > span:nth-child(1)"));
        private IWebElement _eraseCart => Driver.FindElement(By.CssSelector("button.c-btn:nth-child(2)"));
        private IWebElement _cartPrice => Driver.FindElement(By.CssSelector("body > div.b-app > div > header > div.b-header-bottom > div > div > div.b-header-bottom--side.b-header-hidden > div > div > button.b-flex-centered.b-cart-and-delivery-in-header--btn.b-cart-in-header--btn.b-cart-and-delivery-in-header--btn-active > span"));
        private IWebElement _eraseOk => Driver.FindElement(By.CssSelector("div.col-sm-12:nth-child(1) > button:nth-child(1) > span:nth-child(1)"));
        private IWebElement _recomendation => Driver.FindElement(By.CssSelector(".b-products-list--contains-product-card-banner > div:nth-child(7) > div:nth-child(2) > div:nth-child(1) > span:nth-child(2) > button:nth-child(1)"));
        private IWebElement _cartSum => Driver.FindElement(By.CssSelector("body > div.b-app > div > div.container-fluid > div > div.b-sidebar > div > div.b-sidebar--active-cart.b-sidebar--inner > div.b-sidebar--contents > div.b-sidebar-bottom > button.b-sidebar-bottom--side > div.b-sidebar-bottom--side-total-price"));

        public HomePage(IWebDriver webdriver) : base(webdriver)
        { }

        public HomePage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public void AddItem()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_item1Add));
            _item1Add.Click();
        }

        public void Add3Items()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_item1Add));
            _item1Add.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(_item2Add));
            _item2Add.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(_item3Add));
            _item3Add.Click();
        }

        public void EmptyBascet()
        {
            if (_cartPrice.Text != "€0,00")
            {
                _eraseCart.Click();
                _eraseOk.Click();
            }
        }

        public void AssertItemAdded()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_item1NameCart));
            Assert.AreEqual(_item1Name.Text, _item1NameCart.Text, "prekes pavadinimas nesutampa!");
            Assert.AreEqual(_item1Price.Text, _item1PriceCart.Text, "prekes kaina nesutampa!");
        }

        public void AssertItemsAddedCartSum()
        {
            decimal _item1Price = decimal.Parse(_item1PriceCart.Text, NumberStyles.Currency);
            decimal _item2Price = decimal.Parse(_item2PriceCart.Text, NumberStyles.Currency);
            decimal _item3Price = decimal.Parse(_item3PriceCart.Text, NumberStyles.Currency);
            decimal cartPrice = decimal.Parse(_cartSum.Text, NumberStyles.Currency);

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_recomendation));

            decimal allItemsPrice = _item1Price + _item2Price + _item3Price + 0.49M;
            Assert.AreEqual(cartPrice, allItemsPrice, "prekių kaina nesutampa su krepšelio kaina!");

        }
    }
}


