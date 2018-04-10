using System;
using NUnit.Framework;
using System.Threading;

namespace SlotokingUIAuto.Pages
{
    [TestFixture]
    public class RegistrationTests
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            Driver.Browser.Url = TestDataResource.MainPageURL + "/register/";
        }

        [Test]
        public void Registration_ByEmail_Positive()
        {
            Random rnd = new Random();            
            RegistrationPage registr = new RegistrationPage();
            registr.Registration(rnd.Next().ToString() + "@mail.ru", false);
            Thread.Sleep(5000);
            StringAssert.Contains("sorty", Driver.Browser.Url);
        }

        [Test]
        public void Registration_ByPhone_Positive()
        {
            Random rnd = new Random();            
            RegistrationPage registr = new RegistrationPage();                 
            registr.Registration("500508" + rnd.Next(100, 999).ToString(), true);
           
            SortyPage sorty = new SortyPage();
            Thread.Sleep(5000);
            StringAssert.AreEqualIgnoringCase("- ВЫБЕРИТЕ, ЧТО БУДЕМ ДЕЛАТЬ ДАЛЬШЕ? -", sorty.TitleText.Text);
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
