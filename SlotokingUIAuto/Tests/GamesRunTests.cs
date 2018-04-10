using System;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;

namespace SlotokingUIAuto.Pages
{
    [TestFixture]
    public class GamesRunTests
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser(Platforms.Desktop, BrowserTypes.Chrome, 6000);
            Driver.Browser.Manage().Window.Maximize();
        }

        [Test]
        public void GameRun_Positive()
        {           
            Driver.Browser.Url = TestDataResource.MainPageURL  + "/games/all-slots/";
            GamePage games = new GamePage();
            HeaderButtons header = new HeaderButtons();
            header.Auth(TestDataResource.TestUserEmail, false);
            Thread.Sleep(5000);
            games.MoveCursorToGame(0,200);               

            double balance = Convert.ToDouble(games.BalanceText.Text.Substring(0, games.BalanceText.Text.IndexOf(' ')));
          
            games.ReturnFocus();
            Thread.Sleep(60000);
            games.SpinButtonClick();
            Thread.Sleep(15000);
            games.BalanceText.Click();           

            Assert.AreNotEqual(balance, Convert.ToDouble(games.BalanceText.Text.Substring(0, games.BalanceText.Text.IndexOf(' '))));
        }

        [Test]
        public void DemoGameRun_Positive()
        {
            Driver.Browser.Url = TestDataResource.MainPageURL + "/games/all-slots/";
            GamePage games = new GamePage();
            HeaderButtons header = new HeaderButtons();

            Thread.Sleep(5000);
            games.MoveCursorToGame(500, 450);           
            var startSize = new System.Drawing.Size(1400, 800);
            header.PopupCancelButton.Click();
            games.ReturnFocus();
            Thread.Sleep(60000);              
            games.FullscrinButtonClick();                     
            
            if (games.CalcContainerSize().Height > startSize.Height)
            {
                Assert.Pass();
                return;
            }                      
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
