using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.Elements
{
    public class CheckBox : ItemBase
    {
        public static string genericXpath_checkbox = "//td[contains(text(), '{0}')]/following-sibling::td/label/input[@type='checkbox']";

        public void CheckUncheckCheckbox(string checkboxLabel, bool check)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(checkboxLabel))
                {
                    xPath = String.Format(genericXpath_checkbox, checkboxLabel);
                    InfraCheckBox.CheckUncheckCheckBox(xPath, check);
                }
            }catch(Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }
        }
    }
}
