using OpenQA.Selenium;
using SeleniumInfra.InfraElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.Elements
{
    public class Message : ItemBase
    {
        public static string genericXpath_loginErrorMessage = "//div/font[@color='red' and text()='{0}']";        

        public void ValidatePresenceErrorMessage(string message)
        {
            string xPath = "";
            try{
                if(!String.IsNullOrEmpty(message))
                {
                    xPath = String.Format(genericXpath_loginErrorMessage, message);
                    InfraLabel.ValidateExistence(xPath);
                }
            }
            catch(Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }
        }
    }
}
