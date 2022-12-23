using OnlinerStore.Elements;
using OpenQA.Selenium;

namespace OnlinerStore.PageObjects
{
	public class ServicesPage
	{
        private static Button HowItWorksButton => new Button(By.XPath("//span[contains(text(),'Как здесь все устроено?')]"));
        private static TextElement FaqBlock => new TextElement(By.XPath("//div[@class='service-faq']"));

        public void OpenHowItWorksPage()
        {
            HowItWorksButton.Click();
        }

        public void OpenAnswerToTheQuestion(string question)
        {
            FaqBlock.ScrollToElement();
            new Header(By.XPath($"//div[@class='service-faq__header']/a[text()='{question}']")).Click();
        }

        public bool IsAnswerDisplayed(string question) =>
            new TextElement(By.XPath($"//div[contains(@class,'service-faq__item_opened')]//a[text()='{question}']")).IsDisplayed();
    }
}