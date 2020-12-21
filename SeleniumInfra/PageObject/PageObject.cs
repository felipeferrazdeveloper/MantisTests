using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumInfra.Elements;
using SeleniumInfra.InfraElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumInfra.PageObject
{
    public abstract class PageObject
    {        
        protected TextField TextField = new TextField();
        protected Menu Menu = new Menu();
        protected Button Button = new Button();
        protected Label Label = new Label();
        protected Message Message = new Message();
        protected Card Card = new Card();
        protected Select Select = new Select();
        protected TextArea TextArea = new TextArea();
        protected Radio Radio = new Radio();
        protected CheckBox CheckBox = new CheckBox();
        protected Grid Grid = new Grid();
        protected Error Error = new Error();
    }
}
