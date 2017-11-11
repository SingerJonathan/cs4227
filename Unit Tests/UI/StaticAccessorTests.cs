using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cs4227.UI.Tests
{
    [TestClass]
    public class StaticAccessorTests
    {
        [TestMethod]
        public void DoubleToMoneyStringTest()
        {
            double[] testValues = { 1.00, 0.20, 0.03, 4.50, 6.07 };
            string[] expectedResults = { "1.00", "0.20", "0.03", "4.50", "6.07" };
            string[] actualResults = new string[testValues.Length];

            for (int index = 0; index < testValues.Length; index++)
            {
                actualResults[index] = StaticAccessor.DoubleToMoneyString(testValues[index]);
            }
            for (int index = 0; index < testValues.Length; index++)
                Assert.AreEqual(expectedResults[index], actualResults[index]);
        }

        [TestMethod]
        public void HashStringTest()
        {
            string testPassword = "#Badpassword1";
            string expectedHashedPassword = "62b3928b8b91452d67e088e74fc8afbe442195227fc633b7f85910d01e6f787c393336446566696e6974656c794e6f744143756c696e617279496e6772656469656e74343238";
            string actualHashedPassword = StaticAccessor.HashString(testPassword);
            Assert.AreEqual(expectedHashedPassword, actualHashedPassword);
        }
    }
}