using OnlinerStore.Elements;
using OpenQA.Selenium;

namespace OnlinerStore.PageObjects
{
    public class CheckoutPage
    {
        private static Button PaymentInfoButton => new Button(By.XPath("//button[contains(text(),'Перейти к способу оплаты')]"));

        public bool IsPaymentButtonDisplayed => PaymentInfoButton.IsDisplayed();
    }
}