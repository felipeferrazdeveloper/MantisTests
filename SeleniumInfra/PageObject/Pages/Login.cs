using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumInfra.Elements;
using SeleniumInfra.InfraElements;
using System;

namespace SeleniumInfra.PageObject.Pages
{
    public class LoginData
    {
        
        public string username;
        public string password;
        public bool rememeberLogin;
        public bool secureSession;
    }

    public class Login : PageObject
    {            
        public Login PerformLogin(LoginData data)
        {
            TextField.FillValueBy_UiName("Username", data.username);
            TextField.FillValueBy_UiName("Password", data.password);
            Button.ClickButton("Login");
            return this;
        }

        public Login SelectProject(string project)
        {
            Select.SelectProjectGlobal(project);
            Button.ClickButton("Switch");
            return this;
        }

        public Login ValidateSuccessLogin(string username)
        {
            Label.ValidateExistenceLabelByValue(username);
            return this;
        }

        public Login Logout()
        {
            Menu.ClickMenu("Logout");
            return this;
        }

        public Login ValidateErrorMessage(string message)
        {
            Message.ValidatePresenceErrorMessage(message);
            return this;
        }
    }
}
