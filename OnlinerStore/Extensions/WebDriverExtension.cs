using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OnlinerStore.Extensions
{
    public static class WebDriverExtension
    {
        public static TimeSpan Timeout = TimeSpan.FromSeconds(30);

        public static void WaitForElementIsPresent(this IWebDriver driver, By by, int timeoutInSeconds = 30)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(NoSuchElementException));
            wait.Until(d => d.FindElement(by).Displayed && d.FindElement(by).Enabled);
        }

        public static IWebElement GetElement(this IWebDriver driver, By by)
        {
            WaitForElementIsPresent(driver,by);
            return driver.FindElement(by);
        }
    }
}

