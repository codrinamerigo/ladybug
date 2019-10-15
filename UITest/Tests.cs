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

        [Test]
        public void Repl()
        {
            app.Repl();
        }

        [Test]
        public void ShouldBeAbleToLogin()
        {
            //arrange
            app.Tap("UserNameBox");
            app.EnterText("codrina");
            app.DismissKeyboard();
            app.Tap("PasswordBox");
            app.EnterText("password");

            //act
            app.Tap("LoginButton");

            //Assert
            bool result = app.Query(e => e.Marked("WelcomeBox")).Length > 0 ;
            Assert.True(result);
        } 


        
    }
}
