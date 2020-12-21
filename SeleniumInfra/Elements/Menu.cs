using OpenQA.Selenium;
using SeleniumInfra.InfraElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.Elements
{
    public class Menu : ItemBase
    {
        public static string genericXpath_menu = "//td[@class='menu']/a[text()='{0}']";
        
        public void ClickMenu(string menuName)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(menuName))
                {
                    xPath = String.Format(genericXpath_menu, menuName);
                    InfraMenu.Click(xPath);
                }
            }
            catch(Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }
        }

    }
}
