using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace SlotokingUIAuto
{
    public static class Driver
    {     
        private static IWebDriver browser;
        private static AppiumDriver<AndroidElement> mBrowser;
        private static WebDriverWait browserWait;

        public static IWebDriver Browser
        {
            get
            {               
                return browser;
            }
            private set
            {
                browser = value;
            }           
        }

        public static AppiumDriver<AndroidElement> MDriver
        {
            get
            {                
                return mBrowser;
            }
            private set
            {
                mBrowser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {               
                return browserWait;
            }
            private set
            {
                browserWait = value;
            }
        }       

        public static void WaitUntil (By locator)
        {
            Driver.BrowserWait.Until(ExpectedConditions.ElementIsVisible(locator));                
        }
        
        public static void StartBrowser(Platforms platform = Platforms.Desktop, BrowserTypes browserType = BrowserTypes.Chrome, int defaultTimeOut = 30)
        {
            switch (platform)
            {
                case (Platforms.Android):
                    DesiredCapabilities cap = new DesiredCapabilities();
                    //cap.SetCapability("deviceName", "317fe8c");  // lenovo pad
                    cap.SetCapability("deviceName", "1015fae212c72205");   // samsung edge
                    cap.SetCapability("platformVersion", "6.0.0");
                    cap.SetCapability("udid", "1015fae212c72205");
                    cap.SetCapability(MobileCapabilityType.BrowserName, "Chrome");
                    cap.SetCapability("platformName", "Android");
                    Driver.MDriver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
                    BrowserWait = new WebDriverWait(Driver.MDriver, TimeSpan.FromSeconds(defaultTimeOut));
                    break;
                case(Platforms.Desktop):
                    switch (browserType)
                    {
                        case BrowserTypes.Firefox:
                            Driver.Browser = new FirefoxDriver();
                            break;
                        case BrowserTypes.InternetExplorer:
                            Driver.Browser = new InternetExplorerDriver();
                            break;
                        case BrowserTypes.Chrome:
                            Driver.Browser = new ChromeDriver();
                            break;
                        case BrowserTypes.Edge:
                            Driver.Browser = new EdgeDriver();
                            break;
                        default:
                            Driver.Browser = new ChromeDriver();
                            break;                            
                    }
                    BrowserWait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(defaultTimeOut));
                    break;
            }                  
        }

        public static void DisposeBrowser()
        {
            if (Browser != null)
            {
                Browser.Quit();
                Browser = null;
                BrowserWait = null;
            }
            MDriver?.Quit();            
        }
    }
}
