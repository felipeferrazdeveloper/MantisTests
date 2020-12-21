using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumInfra.InfraElements
{
    public class InfraSingleton
    {
        public IWebDriver Driver { get; private set; }
        public int Timeout { get { return 50; } }
        public int TimeoutExistence { get { return 3; } }
        public string Url { get; set; }

        private static InfraSingleton instance = null;

        public static InfraSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InfraSingleton();
                }
                return instance;
            }
        }

        protected InfraSingleton()
        {
            Url = "https://mantis-prova.base2.com.br/";                
        }

        public void ConfigBrowser()
        {
            try
            {
                Driver = new ChromeDriver();
                Driver.Manage().Cookies.DeleteAllCookies();
                Driver.Manage().Window.Maximize();
                Driver.Navigate().GoToUrl(Url);

            }
            catch (Exception e)
            {
                Driver.Close();
                Driver.Quit();
                throw new Exception("Error while conf browser" + e.Message);
            }

        }

        public void Quit()
        {
            try
            {
                Driver.Close();
                Driver.Quit();
            }
            catch(Exception)
            {

            }
        }
    }
}
