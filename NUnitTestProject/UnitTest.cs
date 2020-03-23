using NUnit.Framework;
using Moq;
using LadyBug.ViewModels;
using Xamarin.Forms;
using LadyBug;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    public class Tests
    {
        [TestFixture]
        public class LoginPageViewModelTest
        {
            LoginViewModel _vm;

            [SetUp]
            public void Setup()
            {
                var loginMock = new Mock<IAuthenticationService>().Object;
                _vm = new LoginViewModel(loginMock);
            }



            [Test]
            public async Task Login_UsernameIsSet()
            {
                // Arrange             
                _vm.UserName = "username";

                // Act
                await _vm.InitializeAsync();

                // Assert
               Assert.IsNotNull(_vm.UserName, "Username is null after being initialized with a valid object");
            }

        }
    }
}