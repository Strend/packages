using System;
using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class HeaderButtons 
    {
        public IWebElement LoginButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='enterButtonTop']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='enterButtonTop']"));
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

        public IWebElement TournamentsLnk
        {
            get
            {
                Driver.WaitUntil(By.PartialLinkText("/tournaments/"));
                return Driver.Browser.FindElement(By.PartialLinkText("/tournaments/"));
            }
        }

        public IWebElement BonusesLnk
        {
            get
            {
                Driver.WaitUntil(By.PartialLinkText("/bonuses/"));
                return Driver.Browser.FindElement(By.PartialLinkText("/bonuses/"));
            }
        }

        public IWebElement GamesLnk
        {
            get
            {
                Driver.WaitUntil(By.PartialLinkText("/games/all-slots/#all"));
                return Driver.Browser.FindElement(By.PartialLinkText("/games/all-slots/#all"));
            }
        }

        public IWebElement VIPLnk
        {
            get
            {
                Driver.WaitUntil(By.PartialLinkText("/profile/vip/"));
                return Driver.Browser.FindElement(By.PartialLinkText("/profile/vip/"));
            }
        }

        public IWebElement PaymentsLnk
        {
            get
            {
                Driver.WaitUntil(By.PartialLinkText("/payment-methods/"));
                return Driver.Browser.FindElement(By.PartialLinkText("/payment-methods/"));
            }
        }

        public IWebElement RemindPassButton
        {
            get
            {
                Driver.WaitUntil(By.Id("remindPassword"));
                return Driver.Browser.FindElement(By.Id("remindPassword"));
            }
        }

        public IWebElement LoginTextBox
        {
            get
            {
                Driver.WaitUntil(By.Id("LoginForm_login"));
                return Driver.Browser.FindElement(By.Id("LoginForm_login"));
            }
        }        

        public IWebElement PassTextBox
        {
            get
            {
                Driver.WaitUntil(By.Id("LoginForm_password"));
                return Driver.Browser.FindElement(By.Id("LoginForm_password"));
            }
        }

        public IWebElement PhoneTab
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='AuthForm_type_panel']/span[2]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='AuthForm_type_panel']/span[2]"));
            }
        }        

        public IWebElement ProfileLink
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[1]/a/span"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[1]/a/span"));
            }
        }    

        public IWebElement IncrCash
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[3]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[3]"));
            }
        }       

        public IWebElement SubmitButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login-form']/div[3]/button"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login-form']/div[3]/button"));
            }
        }        

        public IWebElement RemindPassErrorMessage
        {
            get
            {
                Driver.WaitUntil(By.XPath("/html/body/div[6]/div[2]/div[6]"));
                return Driver.Browser.FindElement(By.XPath("/html/body/div[6]/div[2]/div[6]"));
            }
        }

        public IWebElement OkButtonRemindError
        {
            get
            {
                Driver.WaitUntil(By.ClassName("swal2-confirm"));
                return Driver.Browser.FindElement(By.ClassName("swal2-confirm"));
            }
        }

        public IWebElement VKButton
        {
            get
            {
                Driver.WaitUntil(By.ClassName("social-vk"));
                return Driver.Browser.FindElement(By.ClassName("social-vk"));
            }
        }

        public IWebElement FacebookButton
        {
            get
            {                
                 Driver.WaitUntil(By.ClassName("social-fb"));
                 return Driver.Browser.FindElement(By.ClassName("social-fb"));               
            }
        }

        public IWebElement GoogleButton
        {
            get
            {
                Driver.WaitUntil(By.ClassName("social-gp"));
                return Driver.Browser.FindElement(By.ClassName("social-gp"));
            }
        }

        public IWebElement OKButton
        {
            get
            {
                Driver.WaitUntil(By.ClassName("social-od"));
                return Driver.Browser.FindElement(By.ClassName("social-od"));
            }
        }

        public IWebElement TwitterButton
        {
            get
            {
                Driver.WaitUntil(By.ClassName("social-tw"));
                return Driver.Browser.FindElement(By.ClassName("social-tw"));
            }
        }

        public IWebElement MailRUButton
        {
            get
            {
                Driver.WaitUntil(By.ClassName("social-mr"));
                return Driver.Browser.FindElement(By.ClassName("social-mr"));
            }
        }

        public IWebElement BalanceText
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div/div[2]/div[2]/span[1]/text()"));
            }
        }

        public IWebElement RegistrationRightButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='wrapper']/div[1]/div/div[2]/a"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='wrapper']/div[1]/div/div[2]/a"));
            }
        }

        public IWebElement PopupCancelButton
        {
            get
            {
                Driver.WaitUntil(By.Id("onesignal-popover-cancel-button"));
                return Driver.Browser.FindElement(By.Id("onesignal-popover-cancel-button"));
            }
        }        

        public bool Auth (string login, bool isPhone)
        {                      
            LoginButton.Click();
            if (isPhone) PhoneTab.Click();
            LoginTextBox.SendKeys(login);
            PassTextBox.SendKeys(TestDataResource.Password);
            SubmitButton.Click();

            return true;
        }                
    }
}
