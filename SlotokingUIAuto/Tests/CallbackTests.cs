using System;
using NUnit.Framework;

namespace SlotokingUIAuto.Pages
{
    [TestFixture]
    public class CallbackTests
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
        }

        [Test]
        public void Callback_Positive()
        {
            Driver.Browser.Url = "http://callback.slotoking.com/";
            CallbackPage callback = new CallbackPage();
                        
            StringAssert.AreEqualIgnoringCase("Невозможно обработать запрос \"\".", callback.ErrorText.Text);            
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
