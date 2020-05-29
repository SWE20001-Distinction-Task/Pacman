using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using System.Reflection;

namespace TestPacman
{

    [TestFixture]
    public class UnitTest1
    {
        //[Test]
        //public void TestDefault()
        //{
        //    Assert.Pass();
        //}
        //[Test]
        //public void TestAssignment()
        //{
        //    int i = 2;
        //    Assert.AreEqual(i, 2);
        //}
        [Test]//CCL
        public void TestSupermod()
        {
            Pacman_Zagorschi_Franco.Form1 testform1 = new Pacman_Zagorschi_Franco.Form1();
            testform1.supermod2();
            Assert.AreEqual(testform1.Supermod, true);
        }
    }
}
