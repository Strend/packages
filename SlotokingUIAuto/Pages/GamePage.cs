using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System.Threading;

namespace SlotokingUIAuto.Pages
{
    class GamePage
    {
        public IWebElement GameDemoButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[3]/div[2]/div[2]/div[1]/div/a[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[3]/div[2]/div[2]/div[1]/div/a[2]"));
            }
        }

        public IWebElement StartDemoGameButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='startDemoGame']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='startDemoGame']"));
            }
        }       

        public IWebElement BalanceText
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='mCSB_1_container']/div[1]/span/acv"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='mCSB_1_container']/div[1]/span/acv"));
            }
        }

        public IWebElement Magic27PlayButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[4]/div[2]/div[2]/div[1]/div/a[1]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[4]/div[2]/div[2]/div[1]/div/a[1]"));
            }
        }

        public IWebElement GameContainer
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='main-game-frame']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='main-game-frame']"));
            }
        }

        public IWebElement DemoGameButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[4]/div[2]/div[2]/div[1]/div/a[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[4]/div[2]/div[2]/div[1]/div/a[2]"));
            }
        }

        public IWebElement ProgressBar
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='progress-bar']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='progress-bar']"));
            }
        }

        public void MoveCursorToGame(int x, int y)
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveByOffset(x,y).Click().Perform();
                
        }

        public void SpinButtonClick ()
        {            
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(GameContainer, 1150, 730).Click().Perform();            
        }

        public void FullscrinButtonClick()
        {
            Actions actions = new Actions(Driver.Browser);
            actions.MoveToElement(GameContainer, 1170, 30).Click().Perform();
        }

        public void ReturnFocus()
        {
            Driver.Browser.Manage().Window.Size = new System.Drawing.Size(0, 0);
            Thread.Sleep(2000);
            Driver.Browser.Manage().Window.Maximize();
        }

        public System.Drawing.Size CalcContainerSize()
        {
            return GameContainer.Size;
        }
    }
}
