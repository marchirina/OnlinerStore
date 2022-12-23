using OnlinerStore.PageObjects;

namespace OnlinerStore.TestCases.AutoMarket
{
	public class CheckRating : BaseTest
    {
        [Test]
        public void CheckToyotaRAV4Rating()
        {
            Pages.Main.OpenAutoMarketPage();
            Pages.AutoMarket.SelectBrandName("Toyota");
            Pages.AutoMarket.SelectModelName("RAV4");
            Assert.IsTrue(Pages.AutoMarket.IsCarRatingDisplayed);
            Pages.AutoMarket.CheckRatingValue();
        }
    }
}