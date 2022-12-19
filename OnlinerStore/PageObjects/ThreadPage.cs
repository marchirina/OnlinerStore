using OpenQA.Selenium;

namespace OnlinerStore.PageObjects
{
	public class ThreadPage
	{
        public bool IsThreadTitleDisplayed(string titleName) =>
            Browser.Driver.FindElement(By.XPath($"//h1[@title='{titleName}']" )).Displayed;

        public bool IsPinnedMessageDisplayed(string message) =>
            Browser.Driver.FindElement(By.XPath($"//li[contains(@class,'msgfirst')]//p[contains(text(),'{message}')]")).Displayed;
    }
}
