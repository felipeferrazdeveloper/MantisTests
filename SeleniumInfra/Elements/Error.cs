using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.Elements
{
    public class Error : ItemBase
    {
        public static string xPathErrorMandatoryField = @"//td[contains(text(),'APPLICATION ERROR')]/ancestor::tr/following-sibling::tr/td/p[contains(text(),'A necessary field ""{0}"" was empty. Please recheck your inputs.')]";

        public void ValidateErrorMandatoryField(string field)
        {
            string xPath = "";
            try
            {
                if (!String.IsNullOrEmpty(field))
                {
                    xPath = String.Format(xPathErrorMandatoryField, field);
                    InfraError.ValidateExistence(xPath);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }
        }
    }
}

