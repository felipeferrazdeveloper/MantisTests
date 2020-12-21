using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumInfra.InfraElements
{
    public class InfraGrid
    {
        public void CheckGridExistence(string xPath)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(InfraSingleton.Instance.Driver, new TimeSpan(0, 0, InfraSingleton.Instance.Timeout));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(xPath)));
                IWebElement element = InfraSingleton.Instance.Driver.FindElement(By.XPath(xPath));
                if (!element.Displayed)
                    throw new Exception("Element is not visible: " + xPath);
            }
            catch (Exception e)
            {
                throw new Exception("Cannot found element on " + xPath, e);
            }
        }

        public void ClickGridItem(string xPath)
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

        public String GetAttributeValue(String xPath)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(InfraSingleton.Instance.Driver, new TimeSpan(0, 0, InfraSingleton.Instance.Timeout));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(xPath)));
                IWebElement element = InfraSingleton.Instance.Driver.FindElement(By.XPath(xPath));
                return element.Text;
            }
            catch (Exception e)
            {
                throw new Exception("Cannot found element on " + xPath, e);
            }
        }
    }
}
