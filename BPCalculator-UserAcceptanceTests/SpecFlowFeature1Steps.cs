using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BPCalculator_UserAcceptanceTests
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        BPCalculator.BloodPressure bpCalc;

        [Given(@"I run the application")]
        public void GivenIRunTheApplication()
        {
            bpCalc = new BPCalculator.BloodPressure();
        }
        
        [Given(@"I have entered (.*) into systolic field")]
        public void GivenIHaveEnteredIntoSystolicField(int p0)
        {
            bpCalc.Systolic = p0;
        }
        
        [Given(@"I have entered (.*) into the diastolic field")]
        public void GivenIHaveEnteredIntoTheDiastolicField(int p0)
        {
            bpCalc.Diastolic = p0;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeNormalOnTheScreen(BPCalculator.BPCategory category)
        {
            Assert.AreEqual(bpCalc.Category, category);
        }
    }
}
