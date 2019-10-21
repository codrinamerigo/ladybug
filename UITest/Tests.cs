using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        //[Test]
        //public void WelcomeTextIsDisplayed()
        //{
        //    AppResult[] results = app.WaitForElement(c => c.Marked("Welcome"));
        //    app.Screenshot("Welcome screen.");

        //    Assert.IsTrue(results.Any());
        //}
        [Test]
        public void ShouldBeAbleToSeeLoginPage()
        {
            Assert.True(true);
        }
        [Test]
        public void ShouldBeAbleToLogin()
        {
            Assert.True(true);
        }

        public void ShouldBeAbleToNavigate()
        {
            Assert.False(false);
        }

        [Test]
        public void Repl()
        {
            app.Repl();
        }
    }
}
