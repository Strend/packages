using System;
using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class SortyPage
    {
        public SortyPage() //(@"https://slotoking.com/profile/sorty/")
        {
        }

        public IWebElement TitleText
        {
            get
            {
                Driver.WaitUntil(By.ClassName("title"));
                return Driver.Browser.FindElement(By.ClassName("title"));
            }
        }
    }
}