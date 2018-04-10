using System;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;

namespace SlotokingUIAuto
{
    [TestFixture]
    public class GamesRunMobile
    {
        [OneTimeSetUp]
        public void BeforeTestSuit() { }

        [SetUp]
        public void BeforeTest()
        {
            Driver.StartBrowser(Platforms.Android);
        }

        [Test]
        [TestCase("1")]
        [TestCase("3")]
        [TestCase("4")]
        [TestCase("7")]
        [TestCase("8")]
        [TestCase("10")]
        [TestCase("11")]
        [TestCase("12")]
        [TestCase("13")]
        [TestCase("16")]
        [TestCase("17")]
        [TestCase("21")]
        [TestCase("24")]
        [TestCase("25")]
        [TestCase("26")]
        [TestCase("27")]
        [TestCase("28")]
        [TestCase("29")]
        [TestCase("30")]
        [TestCase("31")]
        [TestCase("32")]
        [TestCase("44")]
        [TestCase("47")]
        [TestCase("49")]
        [TestCase("52")]
        [TestCase("57")]
        [TestCase("64")]
        [TestCase("78")]
        [TestCase("79")]
        [TestCase("80")]
        [TestCase("84")]
        [TestCase("86")]
        [TestCase("90")]
        [TestCase("91")]
        [TestCase("92")]
        [TestCase("93")]
        [TestCase("94")]
        [TestCase("100")]
        [TestCase("101")]
        [TestCase("102")]
        [TestCase("103")]
        [TestCase("112")]
        [TestCase("114")]
        [TestCase("115")]
        [TestCase("121")]
        [TestCase("122")]
        [TestCase("130")]
        [TestCase("139")]
        [TestCase("140")]
        [TestCase("146")]
        [TestCase("150")]
        [TestCase("151")]
        [TestCase("152")]
        [TestCase("154")]
        [TestCase("171")]
        [TestCase("172")]
        [TestCase("176")]
        [TestCase("177")]
        [TestCase("178")]
        [TestCase("179")]
        [TestCase("181")]
        [TestCase("182")]
        [TestCase("184")]
        [TestCase("185")]
        [TestCase("186")]
        [TestCase("187")]
        [TestCase("188")]
        [TestCase("192")]
        [TestCase("216")]
        [TestCase("220")]
        public void GameRunMobile_Positive(string count)
        {
            GamesMobile games = new GamesMobile();
            Driver.MDriver.Url = games.GameUri(count);
            games.TapWarning.Click();

            //Assert.AreNotEqual(balance, Convert.ToDouble(games.BalanceText.Text.Substring(0, games.BalanceText.Text.IndexOf(' '))));
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
    

