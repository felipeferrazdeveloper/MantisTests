using NUnit.Framework;
using SeleniumInfra.Common;
using SeleniumInfra.PageObject.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MantisTests.Tests
{
    public class ReportIssuesTests : TestBase
    {
        [Test]
        [Description("Create a report with all fields filled")]
        public void CreateReport()
        {
            ReportIssue reportIssue = new ReportIssue();
            ReportIssueData reportData = new ReportIssueData()
            {
                Category = RandomStuff.RandomCategory(),
                Reproducibility = RandomStuff.RandomReproducibility(),
                Severity = RandomStuff.RandomSeverity(),
                Priority = RandomStuff.RandomPriority(),
                SelectProfile = RandomStuff.RandomProfile(),
                Platform = RandomStuff.RandomStringUpper(10),
                OS = RandomStuff.RandomStringUpper(8),
                OSVersion = RandomStuff.RandomString(3),
                Summary = RandomStuff.RandomStringUpper(40),
                Description = RandomStuff.RandomString(500),
                StepsToReproduce = RandomStuff.RandomString(500),
                AdditionalInformation = RandomStuff.RandomString(500),
                UploadFilePath = "",//falta implementar
                Status_isPublic = false,
                Report_Stay = false
            };
             reportIssue.GoTo()
                .FillFields(reportData)
                .ClickSubmitReportBtn()
                .CheckGridFirstRegister(reportData.Summary);
        }

        [Test]
        [Description("Create a report with just mandatory fields")]
        public void CreateReport_MandatoryFields()
        {
            ReportIssue reportIssue = new ReportIssue();
            ReportIssueData reportData = new ReportIssueData()
            {
                Category = RandomStuff.RandomCategory(),                
                Summary = RandomStuff.RandomStringUpper(40),
                Description = RandomStuff.RandomString(500),                
            };
            reportIssue.GoTo()
               .FillFields(reportData)
               .ClickSubmitReportBtn()
               .CheckGridFirstRegister(reportData.Summary);
        }

        [Test]
        [Description("Create a report without mandatory fields - Category")]
        public void CreateReport_NoCategory()
        {
            ReportIssue reportIssue = new ReportIssue();
            ReportIssueData reportData = new ReportIssueData()
            {
                Reproducibility = RandomStuff.RandomReproducibility(),
                Severity = RandomStuff.RandomSeverity(),
                Priority = RandomStuff.RandomPriority(),
                SelectProfile = RandomStuff.RandomProfile(),
                Platform = RandomStuff.RandomStringUpper(10),
                OS = RandomStuff.RandomStringUpper(8),
                OSVersion = RandomStuff.RandomString(3),
                Summary = RandomStuff.RandomStringUpper(40),
                Description = RandomStuff.RandomString(500),
                StepsToReproduce = RandomStuff.RandomString(500),
                AdditionalInformation = RandomStuff.RandomString(500),
                UploadFilePath = "",//falta implementar
                Status_isPublic = false,
                Report_Stay = false
            };
            reportIssue.GoTo()
               .FillFields(reportData)
               .ClickSubmitReportBtn()
               .ValidateMandatoryFieldErrorMessage("Category");
        }

        [Test]
        [Description("Update a report - Note")]
        public void UpdateReport()
        {
            ReportIssue reportIssue = new ReportIssue();
            ViewIssues viewIssues = new ViewIssues();

            ReportIssueData updateData = new ReportIssueData();
            ReportIssueData reportData = new ReportIssueData()
            {
                Category = RandomStuff.RandomCategory(),
                Reproducibility = RandomStuff.RandomReproducibility(),
                Severity = RandomStuff.RandomSeverity(),
                Priority = RandomStuff.RandomPriority(),
                SelectProfile = RandomStuff.RandomProfile(),
                Platform = RandomStuff.RandomStringUpper(10),
                OS = RandomStuff.RandomStringUpper(8),
                OSVersion = RandomStuff.RandomString(3),
                Summary = RandomStuff.RandomStringUpper(40),
                Description = RandomStuff.RandomString(500),
                StepsToReproduce = RandomStuff.RandomString(500),
                AdditionalInformation = RandomStuff.RandomString(500),
                UploadFilePath = "",//falta implementar
                Status_isPublic = false,
                Report_Stay = false
            };
            reportIssue.GoTo()
               .FillFields(reportData)
               .ClickSubmitReportBtn()
               .CheckGridFirstRegister(reportData.Summary);
            updateData.ID = reportIssue.GetReportId("Viewing Issues");
            updateData.note = RandomStuff.RandomString(700);
            viewIssues.GoTo()
                .SelectGridRow(updateData.ID)
                .FillViewIssuesDetailsFields(updateData);

        }
    }
}
