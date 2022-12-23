using OnlinerStore.Elements;
using OpenQA.Selenium;

namespace OnlinerStore.PageObjects.Popups
{
    public class SearchPopup : BasePopup
    {
        private static Button CompareProductsButtonLocator => new Button(By.XPath("//div[contains(@class,'compare-button__state_initial')]"));
        private IWebElement SearchFrame => new Popup(By.XPath($"{PopupXpath}//iframe[@class='modal-iframe']")).GetElement();

        public SearchPopup() : base("//div[@id='fast-search-modal']")
        {
        }

        public void OpenItemPage(string itemName)
        {
            new TextElement(By.XPath($"//a[contains(text(),'{itemName}')]")).SwitchToPopupAndClick(SearchFrame);
        }

        public void SelectComparisonItem(string itemName)
        {
            new CheckBox(By.XPath($"//div[contains(@class,'product')][.//a[text()='{itemName}']]" +
                                   "//span[contains(@class,'checkbox_yellow')]")).SwitchToPopupAndClick(SearchFrame);
        }

        public void OpenComparePage()
        {
            CompareProductsButtonLocator.SwitchToPopupAndClick(SearchFrame);
        }
    }
}