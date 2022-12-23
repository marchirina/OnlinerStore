using OnlinerStore.Elements;
using OnlinerStore.PageObjects.Popups;
using OpenQA.Selenium;

namespace OnlinerStore.PageObjects
{
	public class MainPage
	{
        private static Button ForumButton => new Button(By.XPath("//a[@class='b-main-navigation__link']/span[contains(text(),'Форум')]"));
        private static Button ServicesButton => new Button(By.XPath("//a[@class='b-main-navigation__link']/span[contains(text(),'Услуги')]"));
        private static Button AutoMarketButton => new Button(By.XPath("//a[@class='b-main-navigation__link']/span[contains(text(),'Автобарахолка')]"));
        private static TextField SearchTextBox => new TextField(By.XPath("//input[@class='fast-search__input']"));
        private static Header LatestTechNewsElement => new Header(By.XPath("//header[contains(@class,'main-page-blocks')]" +
                                                                           "//a[contains(text(),'Технологии')]"));
        private static TextElement TechNewsTab => new TextElement(By.XPath("//li[contains(@class,'project-navigation__item_active')]" +
                                                                           "//span[contains(text(),'Технологии')]"));

        public SearchPopup SearchItem(string itemName)
        {
            SearchTextBox.SendKeys(itemName);

            return new SearchPopup();
        }

        public void SelectLatestTechnicalNews()
        {
            LatestTechNewsElement.ScrollToElement();
            LatestTechNewsElement.Click();
        }

        public bool IsLatestTechNewsSectionDisplayed() => TechNewsTab.IsDisplayed();

        public void OpenForumPage()
        {
            ForumButton.Click();
        }

        public void OpenServicesPage()
        {
            ServicesButton.Click();
        }

        public void OpenAutoMarketPage()
        {
            AutoMarketButton.Click();
        }
    }
}