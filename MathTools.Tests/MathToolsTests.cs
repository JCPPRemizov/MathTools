using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MathTools.Tests
{
    [TestClass]
    public class MathToolsTests
    {
        public static double numberForCalculatePercentage;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            numberForCalculatePercentage = 45670.2d;
        }



        [TestMethod]
        public void SolveQuadraticEquation_2a_3b_1c_minus_05_and_minus_1returned()
        {
            
            List<double> expected = new List<double> { -0.5d, -1d };
            List<dynamic> result =  MathTools.SolveQuadraticEquation(2d, 3d, 1d);

            CollectionAssert.AreEqual(expected, result);


        }


        [TestMethod]
        public void SolveQuadraticEquation_1a_minus_4b_4c_2returned()
        {
            List<double> expected = new List<double> { 2d };
            List<dynamic> result = MathTools.SolveQuadraticEquation(1d, -4d, 4d);

            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod]

        public void SolveQuadraticEquation_1a_4b_29c_minus_2_plus_5i_and_minus_2_minus_5i_returned()
        {
            List<dynamic> expected = new List<dynamic> { "-2+5i", "-2-5i" };
            List<dynamic> result = MathTools.SolveQuadraticEquation(1d, 4d, 29d);

            CollectionAssert.IsSubsetOf(expected, result);

        }

        [TestMethod]
        public void CalculatePercentage_42dot2number_5dot5percentage_2dot321returned()
        {
            double expected = 25346.960d;
            double percentage = 55.5d;
            double delta = 0.002d;

            double result = MathTools.CalculatePercentage(numberForCalculatePercentage, percentage);

            Assert.AreEqual(expected, result, delta);

        }
    }
}
    