using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.Elements
{
    public class Grid : ItemBase
    {
        public static string xpath_gridByTitle = "//form//td[@Class='form-title']/span[contains(text(), '{0}')]";
        public static string xpath_middle = "/ancestor::tr/following-sibling::tr[@Class='spacer']";
        public static string xpath_rowByIndexAndContent = "/following-sibling::tr[{0}]/td[contains(text(),'{1}')]";
        public static string xpath_FirstRowId = "/following-sibling::tr/td/a[1]";
        public static string xpath_RowId = "/following-sibling::tr/td/a[text()='{0}']";
        public void ValidateGridExistence_ByTitle(string title)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(title))
                {
                    xPath = String.Format(xpath_gridByTitle, title);
                    InfraGrid.CheckGridExistence(xPath);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }
        }

        public string GetFirstRowId(string gridTitle)
        {
            string xPath = "";
            try
            {
                xPath = String.Format(xpath_gridByTitle, gridTitle) + xpath_middle + xpath_FirstRowId;
                return InfraGrid.GetAttributeValue(xPath);
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }
            
        }

        public void SelectGridItem(string gridTitle, string itemId)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(gridTitle) && !String.IsNullOrEmpty(itemId))
                    xPath = String.Format(xpath_gridByTitle, gridTitle) + 
                        xpath_middle + 
                        String.Format(xpath_RowId, itemId);
                InfraGrid.ClickGridItem(xPath);

            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }            
        }

        public void ValidateRegisterOnGrid(string gridTitle, int row, string register)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(gridTitle))
                {
                    string XPath_p1 = String.Format(xpath_gridByTitle, gridTitle);
                    if (!String.IsNullOrEmpty(register))
                    {
                        if (register.Length > 100)
                            register = register.Substring(0, 99);
                        xPath = XPath_p1 + xpath_middle + String.Format(xpath_rowByIndexAndContent, row.ToString(), register);
                    }
                    InfraGrid.CheckGridExistence(xPath);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }
        }
    }
}
