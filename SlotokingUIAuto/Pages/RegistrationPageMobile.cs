using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace SlotokingUIAuto
{
    public class RegistrationPageMobile
    {
        public RegistrationPageMobile() //(@"https://slotoking.com/register/")
        {
        }

        public AppiumWebElement RegistrationEmailTextBox
        {
            get
            {
                Driver.WaitUntil(By.Id("RegisterForm_contact"));
                return Driver.MDriver.FindElement(By.Id("RegisterForm_contact"));
            }
        }

        public AppiumWebElement PasswordTextBox
        {
            get
            {
                Driver.WaitUntil(By.Id("RegisterForm_password"));
                return Driver.MDriver.FindElement(By.Id("RegisterForm_password"));
            }
        }         

        public IWebElement RegistrationButtonMobile
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='register-form']/div/button"));
                return Driver.MDriver.FindElement(By.XPath("//*[@id='register-form']/div/button"));
            }
        }        

        public AppiumWebElement EmailTab
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='register - form - data']"));
                return Driver.MDriver.FindElement(By.XPath("//*[@id='register - form - data']"));
            }
        }        

        public AppiumWebElement PhoneTab
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='RegisterForm_type_panel']/span[2]"));
                return Driver.MDriver.FindElement(By.XPath("//*[@id='RegisterForm_type_panel']/span[2]"));
            }
        }

        public AppiumWebElement SendSmsButton
        {
            get
            {
                Driver.WaitUntil(By.ClassName("btn-blue sendAndroidLink"));
                return Driver.MDriver.FindElement(By.ClassName("btn-blue sendAndroidLink"));
            }
        }
    }
}



