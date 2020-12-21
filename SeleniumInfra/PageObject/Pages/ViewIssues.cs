using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumInfra.PageObject.Pages
{
    public class ViewIssues : PageObject
    {
        public ViewIssues GoTo()
        {
            Menu.ClickMenu("View Issues");
            return this;
        }
        public ViewIssues SelectGridRow(string id)
        {
            Grid.SelectGridItem("Viewing Issues", id);
            return this;
        }

        public ViewIssues FillViewIssuesDetailsFields(ReportIssueData data)
        {
            TextArea.FillValueBy_CodeName("bugnote_text", data.note);
            Button.ClickButton("Add Note");
            return this;
        }
    }
}
