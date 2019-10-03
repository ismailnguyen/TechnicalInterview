using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnicalInterview.Exercice2.Tests
{
    [TestClass]
    public class ClosestToZeroDeterminatorTest
    {
        [TestMethod]
        public void One_Number()
        {
            var inputs = new int[]
            {
                0
            };

            var closestToZeroDeterminator = new ClosestToZeroDeterminator(inputs);

            var output = closestToZeroDeterminator.Determine();

            Assert.AreEqual(output, 0);
        }

        [TestMethod]
        public void Multiple_Positive_Numbers()
        {
            var inputs = new int[]
            {
                3,
                10,
                2,
                6
            };

            var closestToZeroDeterminator = new ClosestToZeroDeterminator(inputs);

            var output = closestToZeroDeterminator.Determine();

            Assert.AreEqual(output, 2);
        }

        [TestMethod]
        public void Multiple_Negative_Numbers()
        {
            var inputs = new int[]
            {
                -3,
                -10,
                -2,
                -6
            };

            var closestToZeroDeterminator = new ClosestToZeroDeterminator(inputs);

            var output = closestToZeroDeterminator.Determine();

            Assert.AreEqual(output, -2);
        }

        [TestMethod]
        public void Multiple_Positive_And_Negative_Numbers()
        {
            var inputs = new int[]
            {
                10,
                -6,
                -3,
                6,
            };

            var closestToZeroDeterminator = new ClosestToZeroDeterminator(inputs);

            var output = closestToZeroDeterminator.Determine();

            Assert.AreEqual(output, -3);
        }

        [TestMethod]
        public void Positive_Number_Has_Priority_Over_Negative_Number()
        {
            var inputs = new int[]
            {
                10,
                -6,
                -3,
                3,
                6,
            };

            var closestToZeroDeterminator = new ClosestToZeroDeterminator(inputs);

            var output = closestToZeroDeterminator.Determine();

            Assert.AreEqual(output, 3);
        }
    }
}
