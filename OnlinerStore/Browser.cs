using OnlinerStore.Configurations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace OnlinerStore
{
	public static class Browser
	{
        private static IWebDriver _driver;
        public static TimeSpan DefaultPollingInterval = TimeSpan.FromSeconds(Convert.ToDouble(ConfigurationManager.AppSetting["POLLINGINTERVAL"]));
        public static TimeSpan Timeout = TimeSpan.FromSeconds(Convert.ToDouble(ConfigurationManager.AppSetting["TIMEOUT"]));

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                    throw new NullReferenceException(
                        "The WebDriver browser instance was not initialized. You should first call the method InitializeBrowser.");
                return _driver;
            }
            private set { _driver = value; }
        }

        public static void InitializeBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    if (_driver == null)
                    {
                        _driver = new FirefoxDriver();
                    }

                    break;

                case "Chrome":
                    if (_driver == null)
                    {
                        _driver = new ChromeDriver();
                    }

                    break;
            }
        }

        public static void OpenApplication(string url)
        {
            Driver.Url = url;
        }

        public static void OpenFullScreen()
        {
            Driver.Manage().Window.Maximize();
        }

        public static void GoBackToPage()
        {
            Driver.Navigate().Back();
        }

        public static object ExecuteJavaScript(string javaScript, params object[] args)
        {
            var javaScriptExecutor = (IJavaScriptExecutor)Driver;

            return javaScriptExecutor.ExecuteScript(javaScript, args);
        }

        public static WebDriverWait Wait(TimeSpan timeout = default, TimeSpan pollingInterval = default)
        {
            timeout = timeout.Ticks == 0 ? Timeout : timeout;
            pollingInterval = pollingInterval.Ticks == 0 ? DefaultPollingInterval : pollingInterval;

            return new WebDriverWait(_driver, timeout)
            {
                PollingInterval = pollingInterval
            };
        }

        public static void CloseDriver()
        {
            Driver.Quit();
            Driver = null;
        }
	}
}

