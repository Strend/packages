using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace SlotokingUIAuto
{
    public class GamesMobile
    {

        public string GameUri (string gameCode)
        {
            return "https://rc-games.html-srv.com/launcher.html?userId=500001&game=" + gameCode + "&wshost=wss://rc-games.html-srv.com:8443/";
        }

        public AppiumWebElement TapWarning
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='fullscreenWarning']/div[2]/h3"));
                return Driver.MDriver.FindElement(By.XPath("//*[@id='fullscreenWarning']/div[2]/h3"));
            }
        }


        public void TapForGameRun ()
        {


        }
        
    }
}



