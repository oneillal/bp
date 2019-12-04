using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BPCalculator.UITests.BP
{
    [TestClass]
    public class AutomatedUITests
    {
        public void bpUITest(string systolic, string diastolic, string category)
        {
            String chromeWebDriver = Environment.GetEnvironmentVariable("ChromeWebDriver");

            using (IWebDriver driver = new ChromeDriver(chromeWebDriver))
            {
                // Get localhost testing working
                driver.Navigate().GoToUrl("http://localhost:40328");

                driver.FindElement(By.Id("BP_Systolic")).Clear();
                driver.FindElement(By.Id("BP_Systolic")).SendKeys(systolic);
                driver.FindElement(By.Id("BP_Diastolic")).Clear();
                driver.FindElement(By.Id("BP_Diastolic")).SendKeys(diastolic);
                driver.FindElement(By.Id("BP_Diastolic")).SendKeys(Keys.Tab);

                // Scrape the calculated bp category
                IWebElement node = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(c => c.FindElement(By.Id("BP_Category")));

                StringAssert.Contains(node.Text.ToString(), category);

                driver.Quit();
            }
        }

        [TestMethod]
        [DataRow("101", "78")]
        public void bpUITestNormalBP(string systolic, string diastolic)
        {
            bpUITest(systolic, diastolic, "Normal Blood Pressure");
        }

        [TestMethod]
        [DataRow("77", "50")]
        public void bpUITestLowBP(string systolic, string diastolic)
        {
            bpUITest(systolic, diastolic, "Low Blood Pressure");
        }

        [TestMethod]
        [DataRow("129", "81")]
        public void bpUITestPreHighBP(string systolic, string diastolic)
        {
            bpUITest(systolic, diastolic, "Pre-High Blood Pressure");
        }

        [TestMethod]
        [DataRow("147", "92")]
        public void bpUITestHighBP(string systolic, string diastolic)
        {
            bpUITest(systolic, diastolic, "High Blood Pressure");
        }
    }
}
