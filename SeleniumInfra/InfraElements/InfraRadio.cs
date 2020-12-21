using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.InfraElements
{
    public class InfraRadio
    {
        public void CheckRadioValue(String xPath)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(InfraSingleton.Instance.Driver, new TimeSpan(0, 0, InfraSingleton.Instance.Timeout));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(xPath)));
                IWebElement element = InfraSingleton.Instance.Driver.FindElement(By.XPath(xPath));
                
                element.Click();                           
            }
            catch (Exception e)
            {
                throw new Exception("Cannot found element on " + xPath, e);
            }
        }
    }
}
