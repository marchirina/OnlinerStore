using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OnlinerStore.Configurations;

namespace OnlinerStore.Elements
{
    public abstract class BaseElement   
	{
        private readonly IWebElement _element;
        private readonly By _locator;
        public static TimeSpan DefaultPollingInterval = TimeSpan.FromMilliseconds(Convert.ToDouble
            (ConfigurationManager.AppSetting["POLLINGINTERVAL"]));
        public static TimeSpan Timeout = TimeSpan.FromSeconds(Convert.ToDouble(ConfigurationManager.AppSetting["TIMEOUT"]));
        private IWebElement Element => _element ?? Browser.Driver.FindElements(_locator).FirstOrDefault();

        protected BaseElement(By locator)
        {
            _locator = locator;
        }

        protected BaseElement(IWebElement element)
        {
            _element = element;
        }

        public void ClickViaActions()
        {
            Browser.Wait().Until(waiting =>
            {
                var actions = new Actions(Browser.Driver);
                actions.MoveToElement(Element).Click().Build().Perform();

                return true;
            });
        }

        public void Click()
        {
            Browser.Wait().Until(waiting =>
            {
                try
                {
                    Element.Click();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }

        public void WaitForElementIsDisplayed(int? timeout = null) =>
            Browser.Wait(timeout == null ? Timeout : TimeSpan.FromMilliseconds((int)timeout))
            .Until(drv => Element.Enabled && Element.Displayed);

        public bool IsDisplayed(int timeout = 3000)
        {
            try
            {
                WaitForElementIsDisplayed(timeout);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

