using OpenQA.Selenium;

namespace OnlinerStore.Elements
{
	public class TextField : BaseElement
	{
        public TextField(By locator) : base(locator)
        {
        }

        public void SendKeys(string text)
        {
            WaitForElementIsDisplayed();
            GetElement().SendKeys(text);
        }
    }
}