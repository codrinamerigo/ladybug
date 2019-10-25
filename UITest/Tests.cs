﻿using System;
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
            app.Query(e => e.All());
            app.Tap("LoginButton");
        }
       
        [Test]
        public void ShouldBeAbleToLogin()
        {
            //Arrange

            app.Tap("UserNameBox");
            app.EnterText("codrina");
            app.DismissKeyboard();
            app.Tap("PasswordBox");
            app.EnterText("password");
            app.DismissKeyboard();

            //Act
            app.Tap("LoginButton");

            //Assert
            app.WaitForElement("WelcomeBox");
            bool result = app.Query(e => e.Marked("WelcomeBox")).Any();

            //Assert
            Assert.IsTrue(result);



        }
        
    }
}
