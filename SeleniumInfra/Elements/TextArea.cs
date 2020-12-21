using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.Elements
{
    public class TextArea : ItemBase
    {
        public static string genericXpath_FindBy_UiName = "//td[contains(text(), '{0}')]/following-sibling::td/textarea";
        public static string genericXpath_FindBy_CodeName = "//textarea[@name='{0}']";


        public void FillValueBy_UiName(string uiName, string value)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(value))
                {
                    xPath = String.Format(genericXpath_FindBy_UiName, uiName);
                    InfraTextArea.FillValue(xPath, value);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath + " uiName->" + uiName, e);
            }
        }
        public void FillValueBy_CodeName(string name, string value)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(value))
                {
                    xPath = String.Format(genericXpath_FindBy_CodeName, name);
                    InfraTextArea.FillValue(xPath, value);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath + " name->" + name, e);
            }
        }
    }
}
