using SeleniumExtras.PageObjects;

namespace OnlinerStore.PageObjects.Popups
{
    public class Popups
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }

        public static SearchPopup Search => GetPage<SearchPopup>();
    }
}

