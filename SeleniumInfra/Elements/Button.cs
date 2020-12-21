using OpenQA.Selenium;
using SeleniumInfra.InfraElements;
using System;

namespace SeleniumInfra.Elements
{
    public class Button : ItemBase
    {
        public static string genericXpath_button = "//input[@type='submit' and @value='{0}']";
        
        public void ClickButton(string buttonValue)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(buttonValue))
                {
                    xPath = String.Format(genericXpath_button, buttonValue);
                    InfraButton.Click(xPath);
                }
                    
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }
        }

    }
}
