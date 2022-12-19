using OpenQA.Selenium;
using OnlinerStore.Elements;

namespace OnlinerStore.PageObjects
{
    public class BasketPage
    {
        private static Button CheckoutButton => new Button(By.XPath("//a[contains(text(),'Перейти к оформлению')]"));

        public void OpenCheckoutPage()
        {
            CheckoutButton.ClickViaActions();
        }
    }
}

