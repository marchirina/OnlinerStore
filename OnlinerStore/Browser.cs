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
        public static TimeSpan DefaultPollingInterval = TimeSpan.FromMilliseconds
            (Convert.ToDouble(ConfigurationManager.AppSetting["POLLINGINTERVAL"]));
        public static TimeSpan Timeout = TimeSpan.FromSeconds(Convert.ToDouble(ConfigurationManager.AppSetting["TIMEOUT"]));

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    _driver = InitializeBrowser();
                }
                return _driver;
            }
            private set { _driver = value; }
        }

        public static IWebDriver InitializeBrowser(string browserName= "Chrome")
        {
            switch (browserName)
            {
                case "Firefox":
                    return new FirefoxDriver();
                    
                case "Chrome":
                    return new ChromeDriver();

                default:
                    return new ChromeDriver();
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

        public static WebDriverWait Wait(TimeSpan timeout = default, TimeSpan pollingInterval = default, Type[] exceptionTypes = null)
        {
            timeout = timeout.Ticks == 0 ? Timeout : timeout;
            pollingInterval = pollingInterval.Ticks == 0 ? DefaultPollingInterval : pollingInterval;

            var wait = new WebDriverWait(_driver, timeout)
            {
                PollingInterval = pollingInterval
            };

            wait.IgnoreExceptionTypes(exceptionTypes ?? new[] { typeof(StaleElementReferenceException) });

            return wait;
        }

        public static void CloseDriver()
        {
            Driver.Quit();
            Driver = null;
        }
    }
}