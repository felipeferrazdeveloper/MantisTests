using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.Elements
{
    public class Radio : ItemBase
    {
        public static string genericXpath_radio = "//td[contains(text(), '{0}')]/following-sibling::td/label[contains(text(), '{1}')]/input[@type='radio']";

        public void SelectRadio(string formName, string radioLabel)
        {
            string xPath = "";
            try
            {
                if(!String.IsNullOrEmpty(formName) && !String.IsNullOrEmpty(radioLabel))
                {
                    xPath = String.Format(genericXpath_radio, formName, radioLabel);
                    InfraRadio.CheckRadioValue(xPath);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }

        }
    }
}
