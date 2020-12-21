using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.Elements
{
    public class Select : ItemBase
    {
        public static string parameteredXpath_selectByUILabel = "//tr/td[contains(text(), '{0}')]/following-sibling::td/select";
        public static string parameteredXpath_selectByName = "//select[@name='{0}']";
        public static string genericXpath_globalProject = "//form/select";
        public void SelectValueByUILabel(string label, string value)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(value))
                {
                    xPath = String.Format(parameteredXpath_selectByUILabel, label);
                    InfraSelect.SelectValue(xPath, value);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }
        }

        public void SelectValueByName(string name, string value)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(value))
                {
                    xPath = String.Format(parameteredXpath_selectByName, name);
                    InfraSelect.SelectValue(xPath, value);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }
        }

        public void SelectProjectGlobal(string value)
        {
            try
            {
                if (!String.IsNullOrEmpty(value))
                {                    
                    InfraSelect.SelectValue(genericXpath_globalProject, value);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + genericXpath_globalProject, e);
            }
        }



    }
}
