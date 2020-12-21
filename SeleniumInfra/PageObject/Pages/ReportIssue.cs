using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace SeleniumInfra.PageObject.Pages
{

    public class ReportIssueData
    {
        public string Category;
        public string Reproducibility;
        public string Severity;
        public string Priority;
        public string SelectProfile;
        public string Platform;
        public string OS;
        public string OSVersion;
        public string Summary;
        public string Description;
        public string StepsToReproduce;
        public string AdditionalInformation;
        public string UploadFilePath;
        public bool Status_isPublic;
        public bool Report_Stay;

        public string ID;
        public string note;
    }

    public class ReportIssue : PageObject
    {
        public ReportIssue GoTo()
        {
            Menu.ClickMenu("Report Issue");
            return this;
        }

        public ReportIssue FillFields(ReportIssueData data)
        {
            Select.SelectValueByName("category_id", data.Category);
            Select.SelectValueByUILabel("Reproducibility", data.Reproducibility);
            Select.SelectValueByUILabel("Severity", data.Severity);
            Select.SelectValueByUILabel("Priority", data.Priority);
            Select.SelectValueByUILabel("Select Profile", data.SelectProfile);
            TextField.FillValueBy_UiName("Platform", data.Platform);
            TextField.FillValueBy_UiName("OS", data.OS);
            TextField.FillValueBy_UiName("OS Version", data.OSVersion);
            TextField.FillValueBy_CodeName("summary", data.Summary);
            TextArea.FillValueBy_CodeName("description", data.Description);
            TextArea.FillValueBy_UiName("Steps To Reproduce", data.StepsToReproduce);
            TextArea.FillValueBy_UiName("Additional Information", data.AdditionalInformation);
            if (data.Status_isPublic)
                Radio.SelectRadio("View Status", "public");
            else
                Radio.SelectRadio("View Status", "private");
            CheckBox.CheckUncheckCheckbox("Report Stay", data.Report_Stay);

            return this;
        }

        public ReportIssue ClickSelectProjectBtn()
        {
            Button.ClickButton("Select Project");
            return this;
        }

        public ReportIssue CheckGridFirstRegister(string register)
        {
            Grid.ValidateRegisterOnGrid("Viewing Issues", 1, register);
            return this;
        }

        public ReportIssue ClickSubmitReportBtn()
        {
            Button.ClickButton("Submit Report");
            return this;
        }

        public ReportIssue ChooseProject(string project)
        {
            Select.SelectValueByUILabel("Choose Project", project);
            return this;
        }

        public ReportIssue ValidateMandatoryFieldErrorMessage(string field)
        {
            Error.ValidateErrorMandatoryField(field);
            return this;
        }

        public string GetReportId(string gridTitle)
        {
            return Grid.GetFirstRowId(gridTitle);
        }
    }
}
