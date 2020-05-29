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
        public void TestWriteFile()
        {
            Pacman_Zagorschi_Franco.Form1 testform1 = new Pacman_Zagorschi_Franco.Form1();
            var fullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/testscore.txt";
            testform1.writescore(fullPath, "Testing", 100);
            Assert.IsTrue(File.Exists(fullPath));
            File.Delete(fullPath);
        }
        [Test]//CCL
        public void TestCheckFileExist()
        {
            Pacman_Zagorschi_Franco.Form1 testform1 = new Pacman_Zagorschi_Franco.Form1();
            var fullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/testscore.txt";
            testform1.writescore(fullPath, "Testing", 100);
            testform1.writescore(fullPath, "Testing1", 200);
            Assert.IsTrue(File.Exists(fullPath));
            File.Delete(fullPath);
        }
        [Test]//CCL
        public void TestCountRecord()
        {
            Pacman_Zagorschi_Franco.Form1 testform1 = new Pacman_Zagorschi_Franco.Form1();
            var fullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/testscore.txt";
            testform1.writescore(fullPath, "Testing", 100);
            Assert.AreEqual(testform1.countscorerecord(fullPath), 1);
            File.Delete(fullPath);
        }
    }
}
