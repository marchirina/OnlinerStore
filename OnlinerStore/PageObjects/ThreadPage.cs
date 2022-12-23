using OpenQA.Selenium;
using OnlinerStore.Elements;

namespace OnlinerStore.PageObjects
{
	public class ThreadPage
	{
        public bool IsThreadTitleDisplayed(string titleName) =>
            new Header(By.XPath($"//h1[@title='{titleName}']" )).IsDisplayed();

        public bool IsPinnedMessageDisplayed(string message) =>
            new TextElement(By.XPath($"//li[contains(@class,'msgfirst')]//p[contains(text(),'{message}')]")).IsDisplayed();
    }
}