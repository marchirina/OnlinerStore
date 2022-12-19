using OpenQA.Selenium;

namespace OnlinerStore.Helpers
{
	public class FrameHelper
	{
        public static void SwitchToPopupAndClick(IWebElement element, By by)
        {
            Browser.Driver.SwitchTo().Frame(element);
            WebDriverHelper.WaitAndClick(by);
            Browser.Driver.SwitchTo().DefaultContent();
        }
    }
}

