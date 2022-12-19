using OnlinerStore.Elements;
using OnlinerStore.Extensions;
using OnlinerStore.Helpers;
using OnlinerStore.PageObjects.Popups;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlinerStore.PageObjects
{
	public class MainPage
	{
        private static Button ForumButton => new Button(By.XPath("//a[@class='b-main-navigation__link']/span[contains(text(),'Форум')]"));
        private static Button ServicesButton => new Button(By.XPath("//a[@class='b-main-navigation__link']/span[contains(text(),'Услуги')]"));
        private static Button AutoMarketButton => new Button(By.XPath("//a[@class='b-main-navigation__link']/span[contains(text(),'Автобарахолка')]"));
        private IWebElement _searchTextBox => Browser.Driver.GetElement(By.XPath("//input[@class='fast-search__input']"));

        [FindsBy(How = How.XPath, Using = "//header[contains(@class,'main-page-blocks')]//a[contains(text(),'Технологии')]")]
        private IWebElement _latestTechNewsElement;

        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'project-navigation__item_active')]//span[contains(text(),'Технологии')]")]
        private IWebElement _techNewsTab;

        public SearchPopup SearchItem(string itemName)
        {
            _searchTextBox.SendKeys(itemName);

            return new SearchPopup();
        }

        public void SelectLatestTechnicalNews()
        { 
            JavaScriptHelper.ScrollToElement(_latestTechNewsElement);
            _latestTechNewsElement.Click();
        }

        public bool IsLatestTechNewsSectionDisplayed() => _techNewsTab.Displayed;

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

