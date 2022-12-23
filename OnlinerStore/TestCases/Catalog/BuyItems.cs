using OnlinerStore.PageObjects;
using OnlinerStore.PageObjects.Popups;

namespace OnlinerStore.TestCases.Catalog
{
    public class BuyItems : BaseTest
    {
        [Test]
        public void BuyAirpods()
        {
            Pages.Main.SearchItem("Наушники Apple Airpods Pro 2");
            Popups.Search.OpenItemPage("Наушники Apple AirPods Pro 2");
            Pages.Item.ConfirmLocation();
            Pages.Item.AddItemInBasketForFirstExpandedShop();
            Pages.Item.MoveToBasketPage();
            Pages.Basket.OpenCheckoutPage();
            Assert.IsTrue(Pages.Checkout.IsPaymentButtonDisplayed);
        }
    }
}