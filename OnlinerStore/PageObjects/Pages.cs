namespace OnlinerStore.PageObjects
{
    public class Pages
    {
        public static MainPage Main => new MainPage();
        public static ItemPage Item => new ItemPage();
        public static BasketPage Basket => new BasketPage();
        public static CheckoutPage Checkout => new CheckoutPage();
        public static ComparePage Compare => new ComparePage();
        public static ForumPage Forum => new ForumPage();
        public static ThreadPage Thread => new ThreadPage();
        public static ServicesPage Services => new ServicesPage();
        public static AutoMarketPage AutoMarket => new AutoMarketPage();
    }
}