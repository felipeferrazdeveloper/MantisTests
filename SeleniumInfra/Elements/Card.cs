using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.Elements
{
    public class Card : ItemBase
    {
        public static string genericXpath_cardTitle = "//td/a[text()='{0}']";

        public void ValidateExistenceCardByTitle(string title)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(title))
                {
                    xPath = String.Format(genericXpath_cardTitle, title);
                    InfraCard.ValidateExistence(xPath);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }

        }
    }
}
