using OpenQA.Selenium;

namespace OnlinerStore.Elements
{
	public class Header:BaseElement
	{
        public Header(By locator) : base(locator)
        {
        }

        public Header(IWebElement element) : base(element)
        {
        }
    }
}