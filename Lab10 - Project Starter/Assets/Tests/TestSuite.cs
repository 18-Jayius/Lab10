using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;
        // A Test behaves as an ordinary method
        [Test]
        public void TestSuiteSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestSuiteWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        [Test]
        public void TestAddition()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            yield return null;
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7); 
        }

        [Test]
        public void TestSubtraction()
        {
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }

        [UnityTest]
        public IEnumerator TestUnitySubtraction()
        {
            yield return null;
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);
        }

        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            yield return null;
            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void TestSqrt()
        {
            result = Calculator.CalculatePair(100, 0,"√");
            Assert.AreEqual(result, 10f);
        }

        [UnityTest]
        public IEnumerator TestUnitySqrt()
        {
            yield return null;
            result = Calculator.CalculatePair(100, 0, "√");
            Assert.AreEqual(result, 10f);
        }

         [Test]
        public void TestPow()
        {
            result = Calculator.CalculatePair(6, 2, "^");
            Assert.AreEqual(result, 36);
        }

        [UnityTest]
        public IEnumerator TestUnityPow()
        {
            yield return null;
            result = Calculator.CalculatePair(6, 2, "^");
            Assert.AreEqual(result, 36);
        }
    }
}
