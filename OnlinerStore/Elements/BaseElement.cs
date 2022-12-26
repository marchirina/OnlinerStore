using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OnlinerStore.Configurations;

namespace OnlinerStore.Elements
{
    public abstract class BaseElement
	{
        private readonly IWebElement _element;
        private readonly By _locator;
        public static TimeSpan Timeout = TimeSpan.FromSeconds(TestSettings.Timeout);
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
            Browser.Wait(exceptionTypes: new[] { typeof(ElementNotInteractableException), typeof(ElementClickInterceptedException), typeof(StaleElementReferenceException) })
                .Until(waiting =>
            {
                try
                {
                    WaitForElementIsDisplayed();
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
            .Until(waiting => Element.Displayed && Element.Enabled);

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

        public string Text => Element.Text;

        public int Count() => IsDisplayed() ? Browser.Driver.FindElements(_locator).Count : 0;

        public IWebElement GetElement()
        {
            WaitForElementIsDisplayed();

            return Element;
        }

        public void ScrollToElement() =>
            Browser.ExecuteJavaScript("arguments[0].scrollIntoView({block: 'center'});", Element);

        public void SwitchToPopupAndClick(IWebElement element)
        {
            Browser.Wait().Until(waiting =>
            {
                Browser.Driver.SwitchTo().Frame(element);
                Click();
                Browser.Driver.SwitchTo().DefaultContent();

                return true;
            });
        }
    }
}