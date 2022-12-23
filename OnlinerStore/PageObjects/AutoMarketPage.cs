using OnlinerStore.Elements;
using OpenQA.Selenium;

namespace OnlinerStore.PageObjects
{
	public class AutoMarketPage
	{
        private static Button BrandSelector => new Button(By.XPath("//div[contains(@class,'vehicle-form__filter-overflow')]" +
                                                                   "//div[contains(text(),'Марка')]" +
                                                                   "/parent::div[contains(@class,'vehicle-form__input')]"));
        private static Button ModelSelector => new Button(By.XPath("//div[contains(@class,'vehicle-form__filter-overflow')]" +
                                                                   "//div[contains(text(),'Модель')]" +
                                                                   "/parent::div[contains(@class,'vehicle-form__input')]"));
        private static TextField ModelSearchField => new TextField(By.XPath("//input[@placeholder='Найти модель']"));
        private static TextElement ModelRatingValue => new TextElement(By.XPath("//div[@class='vehicle-form__rating']" +
                                                                      "//div[contains(@class,'vehicle-form__rating-text')]"));

        public void SelectBrandName(string brandName)
        {
            BrandSelector.ScrollToElement();
            BrandSelector.Click();
            new Button(By.XPath($"//li[@title='{brandName}']")).Click();
        }

        public void SelectModelName(string modelName)
        {
            ModelSelector.Click();
            ModelSearchField.SendKeys(modelName);
            new Button(By.XPath($"//li[contains(@class,'dropdown-style__item')]//div[contains(text(),'{modelName}')]"))
                .Click();
            new Header(By.XPath($"//h1[contains(text(),'{modelName}')]")).GetElement();
        }

        public bool IsCarRatingDisplayed => ModelRatingValue.IsDisplayed();

        public void CheckRatingValue()
        {
            ModelRatingValue.ScrollToElement();
            var valueRating = ModelRatingValue.Text;
            Console.WriteLine("The rating for this model is " + valueRating);
        }
    }
}