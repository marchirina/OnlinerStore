using OnlinerStore.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlinerStore.PageObjects
{
	public class ServicesPage
	{
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Как здесь все устроено?')]")]
        private IWebElement _howItWorksButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='service-faq']")]
        private IWebElement _faqBlock;

        public void OpenHowItWorksPage()
        {
            _howItWorksButton.Click();
        }

        public void OpenAnswerToTheQuestion(string question)
        {
            JavaScriptHelper.ScrollToElement(_faqBlock);
            Browser.Driver.FindElement(By.XPath($"//div[@class='service-faq__header']/a[text()='{question}']")).Click();
        }

        public bool IsAnswerDisplayed(string question) =>
            Browser.Driver.FindElement(By.XPath($"//div[contains(@class,'service-faq__item_opened')]//a[text()='{question}']")).Displayed;
    }
}

