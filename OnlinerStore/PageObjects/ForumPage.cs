using OpenQA.Selenium;
using OnlinerStore.Elements;

namespace OnlinerStore.PageObjects
{
	public class ForumPage
	{
        public void OpenForumTheadPage(string threadName)
        {
            new TextElement(By.XPath($"//a[contains(text(),'{threadName}')]")).Click();
        }
    }
}