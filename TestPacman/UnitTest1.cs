using System;
using NUnit.Framework;

namespace TestPacman
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestDefault()
        {
            Assert.Pass();
        }
        [Test]
        public void TestAssignment()
        {
            int i = 2;
            Assert.AreEqual(i, 2);
        }
    }
}
