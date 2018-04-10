using System;
using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class CallbackPage
    {
        public IWebElement ErrorText
        {
            get
            {
                Driver.WaitUntil(By.XPath("/html/body/h2"));
                return Driver.Browser.FindElement(By.XPath("/html/body/h2"));
            }
        }       
    }
}
