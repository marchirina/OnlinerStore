using OpenQA.Selenium;

namespace OnlinerStore.PageObjects
{
    public class ComparePage
    {
        public bool IsFirstItemBetter()
        {
            var firstItemSpec = Browser.Driver.FindElements(By.XPath("//td[3][contains (@class,'cell_accent')]")).Count;
            var secondItemSpec = Browser.Driver.FindElements(By.XPath("//td[4][contains (@class,'cell_accent')]")).Count;

            return firstItemSpec > secondItemSpec;
        }
    }
}

