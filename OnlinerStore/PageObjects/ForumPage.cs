using OpenQA.Selenium;

namespace OnlinerStore.PageObjects
{
	public class ForumPage
	{
        public void OpenForumTheadPage(string threadName)
        {
            Browser.Driver.FindElement(By.XPath($"//a[contains(text(),'{threadName}')]")).Click();
        }
    }
}

