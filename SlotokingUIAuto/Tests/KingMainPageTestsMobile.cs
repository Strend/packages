using System;
using NUnit.Framework;

namespace SlotokingUIAuto.Pages
{
    [TestFixture]
    class KingMainPageTestsMobile
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() {}

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
        }

       // [Test]       
        public void Authorization_ByEmail_Positive()
        {
            KingMainPage king = new KingMainPage();
            Driver.Browser.Url = TestDataResource.MainPageURL;            
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            header.LoginTextBox.SendKeys(TestDataResource.TestUserEmail);
            header.PassTextBox.SendKeys(TestDataResource.Password);
            header.SubmitButton.Click();         
           
            StringAssert.AreEqualIgnoringCase("Профиль", header.ProfileLink.Text);
        }

       // [Test]
        public void Authorization_ByPhone_Positive()
        {
            KingMainPage king = new KingMainPage();
            Driver.Browser.Url = TestDataResource.MainPageURL;
            HeaderButtons header = new HeaderButtons();
            header.LoginButton.Click();
            header.PhoneTab.Click();
            header.LoginTextBox.SendKeys(TestDataResource.TestUserPhone);
            header.PassTextBox.SendKeys(TestDataResource.Password);
            header.SubmitButton.Click();
                       
            StringAssert.AreEqualIgnoringCase("Профиль", header.ProfileLink.Text);
        }

        [TearDown]
        public void AfterTest()
        {
            ProfilePage profile = new ProfilePage();
            profile.Logout(Driver.Browser);
            Driver.DisposeBrowser();
        }

        [OneTimeTearDown]
        public void AfterTestSuit() { }
    }
}
