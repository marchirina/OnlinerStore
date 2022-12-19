using OnlinerStore.Configurations;

namespace OnlinerStore.TestCases
{
    public class BaseTest
        {
        [SetUp]
        public void SetUpTest()
        {
            Browser.InitializeBrowser("Chrome");
            Browser.OpenFullScreen();
            Browser.OpenApplication(ConfigurationManager.AppSetting["URL"]);
            Browser.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
        }

        [TearDown]
        public void TearDownTest()
        {
            Browser.CloseDriver();
        }
    }
}

