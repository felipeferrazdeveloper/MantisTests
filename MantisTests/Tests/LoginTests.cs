using NUnit.Framework;
using SeleniumInfra.Common;
using SeleniumInfra.PageObject.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MantisTests.Tests
{
    class LoginTests : TestBase
    {                

        [Test]
        [Description("Validate error message when user uses a wrong password")]
        public void WrongPassword()
        {
            Login loginPage = new Login();
            LoginData loginPageData = new LoginData()
            {
                username = "felipe.ferraz",
                password = RandomStuff.RandomStringUpper(6)
            };

            loginPage.Logout()                
                .PerformLogin(loginPageData)
                .ValidateErrorMessage("Your account may be disabled or blocked or the username/password you entered is incorrect.");
        }

        

    }
}
