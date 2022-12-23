using OnlinerStore.PageObjects;
using OnlinerStore.PageObjects.Popups;

namespace OnlinerStore.TestCases.Catalog
{
    public class CompareItems : BaseTest
    {
        [Test]
        public void CompareAirpods()
        {
            Pages.Main.SearchItem("Наушники Apple Airpods");
            Popups.Search.SelectComparisonItem("Наушники Apple AirPods Pro 2");
            Popups.Search.SelectComparisonItem("Наушники Apple AirPods 3 (с поддержкой MagSafe)");
            Popups.Search.OpenComparePage();
            Assert.IsTrue(Pages.Compare.IsFirstItemBetter());
        }
    }
}