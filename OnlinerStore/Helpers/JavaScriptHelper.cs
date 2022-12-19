using OpenQA.Selenium;

namespace OnlinerStore.Helpers
{
    public class JavaScriptHelper
    {
        public static void ScrollToElement(IWebElement element)
        {
            Browser.ExecuteJavaScript("arguments[0].scrollIntoView({block: 'center'});", element);
        }
    }
}

