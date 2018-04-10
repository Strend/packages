using System;
using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class KingMainPage
    {
        public KingMainPage() //(@"http://www.slotoking.com/")
        {
        }

        public IWebElement DownloadDesktopButton
        {
            get
            {
                Driver.WaitUntil(By.ClassName("down-install-inst"));
                return Driver.Browser.FindElement(By.ClassName("down-install-inst"));
            }
        }

        public IWebElement SendSmsButton
        {
            get
            {
                Driver.WaitUntil(By.ClassName("btn-blue sendAndroidLink"));
                return Driver.Browser.FindElement(By.ClassName("btn-blue sendAndroidLink"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                Driver.WaitUntil(By.Id("enterButtonTop"));
                return Driver.Browser.FindElement(By.Id("enterButtonTop"));
            }
        }
        
        public IWebElement RegistrationButton
        {
            get
            {
                Driver.WaitUntil(By.ClassName("btn btn-green"));
                return Driver.Browser.FindElement(By.ClassName("btn btn-green"));
            }
        }

        public IWebElement PhoneTextBox
        {
            get
            {
                Driver.WaitUntil(By.Id("PhoneForm_phone"));
                return Driver.Browser.FindElement(By.Id("PhoneForm_phone"));
            }
        }     

        public IWebElement WelcomeText
        {
            get
            {
                Driver.WaitUntil(By.ClassName("seo_h1"));
                return Driver.Browser.FindElement(By.ClassName("seo_h1"));
            }
        }       
    }
}
    


