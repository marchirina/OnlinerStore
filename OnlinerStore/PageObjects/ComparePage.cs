using OpenQA.Selenium;
using OnlinerStore.Elements;

namespace OnlinerStore.PageObjects
{
    public class ComparePage
    {
        public bool IsFirstItemBetter()
        {
            var firstItemSpec = new TextElement(By.XPath("//td[3][contains (@class,'cell_accent')]")).Count();
            var secondItemSpec = new TextElement(By.XPath("//td[4][contains (@class,'cell_accent')]")).Count();

            return firstItemSpec > secondItemSpec;
        }
    }
}