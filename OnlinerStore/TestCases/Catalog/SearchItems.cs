using OnlinerStore.PageObjects;
using OnlinerStore.PageObjects.Popups;

namespace OnlinerStore.TestCases.Catalog
{
	public class SearchItems:BaseTest
	{
        [Test]
        public void SearchAirpods()
        {
            Pages.Main.SearchItem("Наушники Apple Airpods Pro 2");
            Popups.Search.OpenItemPage("Наушники Apple AirPods Pro 2");
            Pages.Item.IsItemHeaderDisplayed();
        }
    }
}

