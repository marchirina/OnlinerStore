using OnlinerStore.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlinerStore.PageObjects
{
    public class ItemPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='catalog-masthead']/h1[contains(text(),'Наушники Apple AirPods Pro 2')]")]
        private IWebElement _itemHeader;

        [FindsBy(How = How.XPath, Using = "//div[@class='product-aside__offers-list']//a[contains(text(),'В корзину')]")]
        private IWebElement _firstExpandedAddToCartButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='popover-style__content']//span[contains(text(),'Да, верно')]")]
        private IWebElement _locationСonfirmationButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Перейти в корзину')]")]
        private IWebElement _moveToBasketButton;

        public void IsItemHeaderDisplayed()
        {
            Browser.Driver.ConfirmElementIsDisplayed(_itemHeader);
        }

        public void ConfirmLocation()
        {
            _locationСonfirmationButton.Click();
        }

        public void AddItemInBasketForFirstExpandedShop()
        {
            _firstExpandedAddToCartButton.Click();
        }

        public void MoveToBasketPage()
        {
            _moveToBasketButton.Click();
        }
    }
}

