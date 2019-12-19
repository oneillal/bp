using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPCalculator;

namespace UnitTests
{
    [TestClass]
    public class BloodPressureCategoryUnitTests
    {
        [TestMethod]
        public void bpCategoryLowTest()
        {
            BloodPressure bp = new BloodPressure
            {
                Systolic = 88,
                Diastolic = 55
            };
            Assert.AreEqual(BPCategory.Low, bp.Category);
        }
        [TestMethod]
        public void bpCategoryNormalTest()
        {
            BloodPressure bp = new BloodPressure
            {
                Systolic = 100,
                Diastolic = 63
            };
            Assert.AreEqual(BPCategory.Normal, bp.Category);

        }
        [TestMethod]
        public void bpCategoryPreHighTest()
        {
            BloodPressure bp = new BloodPressure
            {
                Systolic = 121,
                Diastolic = 86
            };
            Assert.AreEqual(BPCategory.PreHigh, bp.Category);
        }
        [TestMethod]
        public void bpCategoryHighTest()
        {
            BloodPressure bp = new BloodPressure
            {
                Systolic = 144,
                Diastolic = 99
            };
            Assert.AreEqual(BPCategory.High, bp.Category);
        }
        [TestMethod]
        public void bpCategoryHighSecondTest()
        {
            BloodPressure bp = new BloodPressure
            {
                Systolic = 132,
                Diastolic = 99
            };
            Assert.AreEqual(BPCategory.High, bp.Category);
        }
        //[TestMethod]
        //public void bpCategoryNegativeTest()
        //{
        //    BloodPressure bp = new BloodPressure
        //    {
        //        Systolic = 99,
        //        Diastolic = 39
        //    };
        //    Assert.AreEqual(BPCategory.High, bp.Category);
        //}
    }
}
