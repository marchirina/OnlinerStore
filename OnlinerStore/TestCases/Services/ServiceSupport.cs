using OnlinerStore.PageObjects;

namespace OnlinerStore.TestCases.Services
{
	public class ServiceSupport : BaseTest
    {
        [Test]
        public void FindAnswerHowToPlaceTheOrder()
        {
            Pages.Main.OpenServicesPage();
            Pages.Services.OpenHowItWorksPage();
            Pages.Services.OpenAnswerToTheQuestion("Как разместить заказ?");
            Assert.IsTrue(Pages.Services.IsAnswerDisplayed("Как разместить заказ?"));
        }
    }
}