using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.InfraElements
{
    public class InfraMessage 
    {
       public void ValidateExistence(string xPath)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(InfraSingleton.Instance.Driver, new TimeSpan(0, 0, InfraSingleton.Instance.TimeoutExistence));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(xPath)));
                IWebElement element = InfraSingleton.Instance.Driver.FindElement(By.XPath(xPath));
                if (!element.Displayed)
                    throw new Exception("Element found but not displayed" + xPath);
            }
            catch (Exception e)
            {
                throw new Exception("Not found element: " + xPath, e);
            }
        }
    }
}
