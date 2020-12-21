using OpenQA.Selenium;
using SeleniumInfra.InfraElements;

namespace SeleniumInfra.Elements
{
    public class ItemBase
    {
        protected InfraButton InfraButton = new InfraButton();
        protected InfraTextField InfraTextField = new InfraTextField();
        protected InfraLabel InfraLabel = new InfraLabel();
        protected InfraMenu InfraMenu = new InfraMenu();
        protected InfraMessage InfraMessage = new InfraMessage();
        protected InfraCard InfraCard = new InfraCard();
        protected InfraSelect InfraSelect = new InfraSelect();
        protected InfraTextArea InfraTextArea = new InfraTextArea();
        protected InfraRadio InfraRadio = new InfraRadio();
        protected InfraCheckBox InfraCheckBox = new InfraCheckBox();
        protected InfraGrid InfraGrid = new InfraGrid();
        protected InfraError InfraError = new InfraError();
    }
}
