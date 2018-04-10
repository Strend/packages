using System;
using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    public class SocialNetworkPages
    {
        public IWebElement VKLoginTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login_submit']/div/div/input[6]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login_submit']/div/div/input[6]"));
            }
        }

        public IWebElement VKPassTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login_submit']/div/div/input[7]"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login_submit']/div/div/input[7]"));
            }
        }

        public IWebElement VKLoginButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='install_allow']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='install_allow']"));
            }
        }

        public IWebElement FaceBookLoginTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='email']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='email']"));
            }
        }

        public IWebElement FaceBookPassTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='pass']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='pass']"));
            }
        }

        public IWebElement FaceBookLoginButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='loginbutton']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='loginbutton']"));
            }
        }

        public IWebElement GoogleLoginTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='identifierId']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='identifierId']"));
            }
        }

        public IWebElement GoogleNextButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='identifierNext']/content/span"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='identifierNext']/content/span"));
            }
        }       

        public IWebElement GooglePassTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='password']/div[1]/div/div[1]/input"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='password']/div[1]/div/div[1]/input"));
            }
        }

        public IWebElement GoogleLoginButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='loginbutton']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='loginbutton']"));
            }
        }

        public IWebElement GooglePassNextButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='passwordNext']/content/span"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='passwordNext']/content/span"));
            }
        }        

        public IWebElement TwitterLoginTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='username_or_email']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='username_or_email']"));
            }
        }

        public IWebElement TwitterPassTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='password']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='password']"));
            }
        }

        public IWebElement TwitterLoginButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='allow']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='allow']"));
            }
        }       
        
        public IWebElement OKLoginTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='field_email']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='field_email']"));
            }
        }

        public IWebElement OKPassTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='field_password']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='field_password']"));
            }
        }

        public IWebElement OKLoginButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='mainW']/div[2]/div/div/form/div[4]/input"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='mainW']/div[2]/div/div/form/div[4]/input"));
            }
        }

        public IWebElement MailLoginTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login']"));
            }
        }

        public IWebElement MailPassTextBox
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='password']"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='password']"));
            }
        }

        public IWebElement MailRULoginButton
        {
            get
            {
                Driver.WaitUntil(By.XPath("//*[@id='login-form']/div[2]/button"));
                return Driver.Browser.FindElement(By.XPath("//*[@id='login-form']/div[2]/button"));
            }
        }
    }
}
