using OnlinerStore.PageObjects;

namespace OnlinerStore.TestCases.News
{
    public class ReadNews : BaseTest
    {
        [Test]
        public void ReadLatestTechNews()
        {
            Pages.Main.SelectLatestTechnicalNews();
            Assert.IsTrue(Pages.Main.IsLatestTechNewsSectionDisplayed());
        }
    }
}