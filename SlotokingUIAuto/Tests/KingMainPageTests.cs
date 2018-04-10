using System;
using NUnit.Framework;

namespace SlotokingUIAuto.Pages
{
    [TestFixture]
    class KingMainPageTests
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() {}

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
        }

        [Test]
        public void Authorization_ByEmailWithSymbols_Positive()
        {
            KingMainPage king = new KingMainPage();
            HeaderButtons header = new HeaderButtons();
            Driver.Browser.Url = TestDataResource.MainPageURL;

            header.Auth(TestDataResource.TestUserEmailWithSymbols, false);

            StringAssert.AreEqualIgnoringCase("Профиль", header.ProfileLink.Text);
        }

        [Test]
        public void Authorization_ByPhone_Positive()
        {
            KingMainPage king = new KingMainPage();
            HeaderButtons header = new HeaderButtons();
            Driver.Browser.Url = TestDataResource.MainPageURL;
                        
            header.Auth(TestDataResource.TestUserPhone, true);

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
