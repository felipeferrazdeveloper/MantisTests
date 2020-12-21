using NUnit.Framework;
using SeleniumInfra.InfraElements;
using SeleniumInfra.PageObject.Pages;

namespace MantisTests
{
    public class TestBase
    {
        [SetUp]
        public void TestSetup()
        {
            InfraSingleton.Instance.ConfigBrowser();
            Login loginPage = new Login();
            LoginData loginPageData = new LoginData()
            {
                username = "felipe.ferraz",
                password = "Qwerty@123"
            };

            loginPage
                .PerformLogin(loginPageData)
                .ValidateSuccessLogin(loginPageData.username)
                .SelectProject("Felipe Ferraz´s Project");
        }

        [TearDown]
        public void TestFinish()
        {
            InfraSingleton.Instance.Quit();
        }
    }
}