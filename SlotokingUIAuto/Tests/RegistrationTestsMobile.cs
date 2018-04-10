using System;
using NUnit.Framework;
using System.Threading;

namespace SlotokingUIAuto.Pages
{
    [TestFixture]
    public class RegistrationTestsMobile
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser(Platforms.Android);
            Driver.Browser.Url = TestDataResource.MainPageURL + "/register/";
        }

     // [Test]       
        public void RegistrationByEmail_Positive_Mobile()
        {            
            Random rnd = new Random();            
           
            RegistrationPage registr = new RegistrationPage();
            registr.Registration(rnd.Next().ToString() + "@mail.ru", false);

            // StringAssert.Contains(Driver.MDriver.Url, "profile");   здесь надо подождать перехода на профайл мобильный и ассертить
        }       

     // [Test]
        public void Registration_ByPhone_Positive()
        {
            Random rnd = new Random();            
            RegistrationPage registr = new RegistrationPage();
            registr.PhoneTab.Click();
            registr.Registration("500508" + rnd.Next(100, 999).ToString(), true);
            SortyPage sorty = new SortyPage();

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
