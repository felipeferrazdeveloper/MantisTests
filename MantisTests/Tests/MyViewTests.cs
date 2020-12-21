using NUnit.Framework;
using SeleniumInfra.InfraElements;
using SeleniumInfra.PageObject.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MantisTests.Tests
{
    public class MyViewTests : TestBase
    {
        [Test]
        [Description("Validate all set cards are shown on My View")]
        public void CheckVisibleCards()
        {
            MyView myView = new MyView();
            myView.GoTo()
                .ValidateCardVisible("Unassigned")
                .ValidateCardVisible("Reported by Me")
                .ValidateCardVisible("Resolved")
                .ValidateCardVisible("Recently Modified")                
                .ValidateCardVisible("Monitored by Me");
        }        

    }
}
