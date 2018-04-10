using System;
using NUnit.Framework;
using System.Threading;

namespace SlotokingUIAuto
{
    [TestFixture]
    public class ProfileTests
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
        public void Profile_FillTitle()
        {           
            RegistrationPage registr = new RegistrationPage();
            Random rnd = new Random();
            registr.Registration(rnd.Next().ToString() + "@mail.ru", false);
            Thread.Sleep(5000);
            Driver.Browser.Url = TestDataResource.MainPageURL + "/profile/account/";            

            Profile_AccountPage account = new Profile_AccountPage();
            account.NameTextBox.SendKeys(TestDataResource.UserName);
            account.SurnameTextBox.SendKeys(TestDataResource.UserSurname);
            account.NicknameTextBox.SendKeys(TestDataResource.UserNickname);
            account.MaleGenderRadioButton.Click();
            account.FillDate();
            account.SaveTitleButton.Click();

            Assert.IsTrue(account.SuccessSaveMessage.Displayed);
        }

        [Test]
        public void Profile_FillPhone()
        {
            RegistrationPage registr = new RegistrationPage();
            Random rnd = new Random();
            registr.Registration(rnd.Next().ToString() + "@mail.ru", false);
            Thread.Sleep(5000);
            Driver.Browser.Url = TestDataResource.MainPageURL + "/profile/account/";

            Profile_AccountPage account = new Profile_AccountPage();
            account.PlayerPhoneTextBox.SendKeys("500508" + rnd.Next(100, 999).ToString());
            account.SavePhoneButton.Click();

            Assert.IsTrue(account.SuccessSaveMessage.Displayed);
        }

  //      [Test]
        public void Profile_FillPersonalInfo()
        {
            RegistrationPage registr = new RegistrationPage();
            Random rnd = new Random();
            registr.Registration(rnd.Next().ToString() + "@mail.ru", false);
            Thread.Sleep(5000);
            Driver.Browser.Url = TestDataResource.MainPageURL + "/profile/account/";

            Profile_AccountPage account = new Profile_AccountPage();
            account.ChooseCountry();
            account.CityTextBox.SendKeys("Kyiv");
            account.AddressListBox.SendKeys("23007 Ukraine, Kyiv, Hreschatic 25/12");
            account.SavePersonalInfoButton.Click();

            Assert.IsTrue(account.SuccessSaveMessage.Displayed);
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
