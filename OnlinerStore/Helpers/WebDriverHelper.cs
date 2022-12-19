using OnlinerStore.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlinerStore.Helpers
{
	public class WebDriverHelper
	{
        public static void WaitAndClick(By by)
        {
            var wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(30));
            wait.IgnoreExceptionTypes(typeof(ElementClickInterceptedException));
            wait.Until(drv =>
            {
                drv.GetElement(by).Click();

                return true;
            });
        }
    }
}

