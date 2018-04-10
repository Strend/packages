using System;
using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class ProfilePage
    {
        public IWebElement DashboardTab
        {
            get
            {
                Driver.WaitUntil(By.ClassName("active"));
                return Driver.Browser.FindElement(By.ClassName("active"));
            }
        }

        public IWebElement DepositForm
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[2]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[2]/a"));
            }
        }

        public IWebElement AccountTab
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[3]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[3]/a"));
            }
        }

        public IWebElement BonusesPersonalTab
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[4]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[4]/a"));
            }
        }

        public IWebElement ProfileHeaderText
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[3]/div/div/div"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div/div/div"));
            }
        }

        public IWebElement SuccessSaveMessage
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='profile-form']/div/div/div[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='profile-form']/div/div/div[2]"));
            }
        }

        public void Logout(IWebDriver webdriver)
        {
            webdriver.Url = TestDataResource.MainPageURL + "/profile/dashboard/";
           // Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[5]/a"));
            IWebElement logout = webdriver.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div/div/ul/li[5]/a"));
            logout.Click();
        }    
    }
}
