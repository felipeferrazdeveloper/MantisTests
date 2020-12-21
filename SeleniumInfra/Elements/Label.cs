using OpenQA.Selenium;
using SeleniumInfra.InfraElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.Elements
{
    public class Label : ItemBase
    {
        public static string genericXpath_span = "//td/span[contains(text(), '{0}')]";
        
        public void ValidateExistenceLabelByValue(string value)
        {
            string xPath = "";
            try
            {
                if(!String.IsNullOrEmpty(value))
                {
                    xPath = String.Format(genericXpath_span, value);
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
