using SeleniumExtras.PageObjects;

namespace OnlinerStore.PageObjects
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }

        public static MainPage Main => GetPage<MainPage>();
        public static ItemPage Item => GetPage<ItemPage>();
        public static BasketPage Basket => GetPage<BasketPage>();
        public static CheckoutPage Checkout => GetPage<CheckoutPage>();
        public static ComparePage Compare => GetPage<ComparePage>();
        public static ForumPage Forum => GetPage<ForumPage>();
        public static ThreadPage Thread => GetPage<ThreadPage>();
        public static ServicesPage Services => GetPage<ServicesPage>();
        public static AutoMarketPage AutoMarket => GetPage<AutoMarketPage>();
    }
}

