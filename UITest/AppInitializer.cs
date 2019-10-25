using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile("C:/Users/cmerigo/source/repos/LadyBug/LadyBug.Android/bin/Release/com.companyname.ladybug.apk")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}