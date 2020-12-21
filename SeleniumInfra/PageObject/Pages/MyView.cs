using OpenQA.Selenium;

namespace SeleniumInfra.PageObject.Pages
{
    public class MyView : PageObject
    {
        public MyView GoTo()
        {
            Menu.ClickMenu("My View");
            return this;
        }
        public MyView ValidateCardVisible(string title)
        {
            Card.ValidateExistenceCardByTitle(title);
            return this;
        }
       
    }
}
