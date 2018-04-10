using System;
using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class RegistrationPage
    {
        public RegistrationPage() //(@"https://slotoking.com/register/")
        {
        }

        public IWebElement RegistrationEmailTextBox
        {
            get
            {
                Driver.WaitUntil(By.Id("RegisterForm_contact"));
                return Driver.Browser.FindElement(By.Id("RegisterForm_contact"));
            }
        }

        public IWebElement PasswordTextBox
        {
            get
            {
                Driver.WaitUntil(By.Id("RegisterForm_password"));
                return Driver.Browser.FindElement(By.Id("RegisterForm_password"));
            }
        }

        public IWebElement AgreeCheckBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='RegisterForm_agree-styler']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='RegisterForm_agree-styler']"));
            }
        }

        public IWebElement RegistrationButton
        {
            get
            {                
                Driver.WaitUntil(By.XPath("//*[@id='register-form-email']/div[5]/button"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='register-form-email']/div[5]/button"));
            }
        }

        public IWebElement RegistrationButtonMobile
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='register - form']/div/button/span"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='register - form']/div/button/span"));
            }
        }        

        public IWebElement EmailTab
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='register - form - data']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='register - form - data']"));
            }
        }        

        public IWebElement PhoneTab
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='RegisterForm_type_panel']/span[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='RegisterForm_type_panel']/span[2]"));
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

        public void Registration (string login, bool isPhone)
        {
            Driver.Browser.Url = TestDataResource.MainPageURL + "/register/";
            if (isPhone) PhoneTab.Click();
            RegistrationEmailTextBox.SendKeys(login);
            PasswordTextBox.SendKeys(TestDataResource.Password);           
            AgreeCheckBox.Click();           
            RegistrationButton.Click();
        }
    }
}



