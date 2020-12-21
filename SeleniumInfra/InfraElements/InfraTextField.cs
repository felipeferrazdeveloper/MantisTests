using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumInfra.InfraElements
{
    public class InfraTextField 
    {
        public void FillValue(string xPath, string value)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(InfraSingleton.Instance.Driver, new TimeSpan(0, 0, InfraSingleton.Instance.TimeoutExistence));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(xPath)));
                IWebElement element = InfraSingleton.Instance.Driver.FindElement(By.XPath(xPath));
                element.Clear();
                element.SendKeys(value);
            }
            catch(Exception e)
            {
                throw new Exception("Cannot found element on " + xPath + " value->" + value, e);
            }
        }

        public void ClearTextField(string xPath)
        {
            WebDriverWait wait = new WebDriverWait(InfraSingleton.Instance.Driver, new TimeSpan(0, 0, InfraSingleton.Instance.Timeout));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(xPath)));
            IWebElement element = InfraSingleton.Instance.Driver.FindElement(By.XPath(xPath));
            element.Clear();
            element.SendKeys(Keys.Tab);            
        }
    }
}
