using System;
using NUnit.Framework;

namespace SlotokingUIAuto.Pages
{
    [TestFixture]
    public class AuthTests
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { } 
            
        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Url = TestDataResource.MainPageURL;
        }

        [Test]
        public void Authorization_RestorePass_Negative()
        {            
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            header.PhoneTab.Click();
            header.RemindPassButton.Click();           

            StringAssert.AreEqualIgnoringCase("Данный телефон не найден", header.RemindPassErrorMessage.Text);
            header.OkButtonRemindError.Click();
        }

        [Test]
        public void Authorization_RestorePassEmail_Positive()
        {            
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            header.LoginTextBox.Clear();
            header.LoginTextBox.SendKeys(TestDataResource.TestRestoreUserEmail);
            header.RemindPassButton.Click();
            
            ///TODO добавить проверку почты           
        }

        [Test]
        public void Authorization_VKLogin_Positive()
        {           
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            header.VKButton.Click();

            SocialNetworkPages vk = new SocialNetworkPages();
            vk.VKLoginTextBox.SendKeys(TestDataResource.VKLogin);
            vk.VKPassTextBox.SendKeys(TestDataResource.VKPass);
            vk.VKLoginButton.Click();

            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("- ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        public void Authorization_FacebookLogin_Positive()
        {            
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            header.FacebookButton.Click();

            SocialNetworkPages facebook = new SocialNetworkPages();
            facebook.FaceBookLoginTextBox.SendKeys(TestDataResource.FacebookLogin);
            facebook.FaceBookPassTextBox.SendKeys(TestDataResource.FacebookPass);
            facebook.FaceBookLoginButton.Click();

            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("- ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        public void Authorization_GoogleLogin_Positive()
        {            
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            header.GoogleButton.Click();

            SocialNetworkPages google = new SocialNetworkPages();
            google.GoogleLoginTextBox.SendKeys(TestDataResource.GoogleLogin);
            google.GoogleNextButton.Click();
            google.GooglePassTextBox.SendKeys(TestDataResource.GooglePass);
            google.GooglePassNextButton.Click();


            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("- ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        public void Authorization_OK_Positive()
        {            
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            header.OKButton.Click();

            SocialNetworkPages ok = new SocialNetworkPages();
            ok.OKLoginTextBox.SendKeys(TestDataResource.OkLogin);
            ok.OKPassTextBox.SendKeys(TestDataResource.OKPass);
            ok.OKLoginButton.Click();

            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("- ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        public void Authorization_MailRU_Positive()
        {            
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            header.MailRUButton.Click();

            SocialNetworkPages mail = new SocialNetworkPages();
            mail.MailLoginTextBox.SendKeys(TestDataResource.MailRuLogin);
            mail.MailPassTextBox.SendKeys(TestDataResource.MailRUPass);
            mail.MailRULoginButton.Click();

            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("- ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        public void Authorization_Twitter_Positive()
        {            
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            header.TwitterButton.Click();

            SocialNetworkPages twitter = new SocialNetworkPages();
            twitter.TwitterLoginTextBox.SendKeys(TestDataResource.TwitterLogin);
            twitter.TwitterPassTextBox.SendKeys(TestDataResource.TwitterPass);
            twitter.TwitterLoginButton.Click();

            ProfilePage profile = new ProfilePage();
            StringAssert.Contains("- ПРОФИЛЬ", profile.ProfileHeaderText.Text);
        }

        [Test]
        public void Authorization_RestorePassPhone_Positive()
        {           
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            header.PhoneTab.Click();
            header.LoginTextBox.Clear();
            header.LoginTextBox.SendKeys(TestDataResource.TestRestoreUserPhone);
            header.RemindPassButton.Click();

            ///TODO добавить проверку почты           
        }

        [TearDown]
        public void AfterTest()
        {
            Driver.DisposeBrowser();
        }

        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }
}
