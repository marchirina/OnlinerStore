using OnlinerStore.Elements;
using OpenQA.Selenium;

namespace OnlinerStore.PageObjects
{
    public class ItemPage
    {
        private static Header ItemHeader => new Header(By.XPath("//div[@class='catalog-masthead']" +
                                                                "/h1[contains(text(),'Наушники Apple AirPods Pro 2')]"));
        private static Button FirstExpandedAddToCartButton => new Button(By.XPath("//div[@class='product-aside__offers-list']" +
                                                                                  "//a[contains(text(),'В корзину')]"));
        private static Button LocationСonfirmationButton => new Button(By.XPath("//div[@class='popover-style__content']" +
                                                                                "//span[contains(text(),'Да, верно')]"));
        private static Button MoveToBasketButton => new Button(By.XPath("//a[contains(text(),'Перейти в корзину')]"));

        public bool IsItemHeaderDisplayed => ItemHeader.IsDisplayed();

        public void ConfirmLocation()
        {
            LocationСonfirmationButton.Click();
        }

        public void AddItemInBasketForFirstExpandedShop()
        {
            FirstExpandedAddToCartButton.Click();
        }

        public void MoveToBasketPage()
        {
            MoveToBasketButton.Click();
        }
    }
}