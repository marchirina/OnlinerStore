using OnlinerStore.Elements;
using OnlinerStore.Extensions;
using OnlinerStore.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlinerStore.PageObjects
{
	public class AutoMarketPage
	{
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'vehicle-form__filter-overflow')]//div[contains(text(),'Марка')]" +
                                          "/parent::div[contains(@class,'vehicle-form__input')]")]
        private IWebElement _brandSelector;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'vehicle-form__filter-overflow')]" +
                                          "//div[contains(text(),'Модель')]/parent::div[contains(@class,'vehicle-form__input')]")]
        private IWebElement _modelSelector;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Найти модель']")]
        private IWebElement _modelSearchField;

        [FindsBy(How = How.XPath, Using = "//div[@class='vehicle-form__rating']" +
                                          "//div[contains(@class,'vehicle-form__rating-text')]")]
        private IWebElement _modelRatingValue;

        public void SelectBrandName(string brandName)
        {
            JavaScriptHelper.ScrollToElement(_brandSelector);
            _brandSelector.Click();
            new Button(By.XPath($"//li[@title='{brandName}']")).Click();
        }

        public void SelectModelName(string modelName)
        {
            new Button(_modelSelector).Click();
            _modelSearchField.SendKeys(modelName);
            new Button(By.XPath($"//li[contains(@class,'dropdown-style__item')]//div[contains(text(),'{modelName}')]"))
                .Click();
            Browser.Driver.GetElement(By.XPath($"//h1[contains(text(),'{modelName}')]"));
        }

        public void IsCarRatingDisplayed()
        {
           Browser.Driver.ConfirmElementIsDisplayed(_modelRatingValue);
        }

        public void CheckRatingValue()
        {
            JavaScriptHelper.ScrollToElement(_modelRatingValue);
            var valueRating = _modelRatingValue.Text;
            Console.WriteLine("The rating for this model is " + valueRating);
        }
    }
}

