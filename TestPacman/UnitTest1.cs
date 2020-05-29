using System;
using NUnit.Framework;
using Pacman_Zagorschi_Franco;

namespace TestPacman
{
    
    [TestFixture]
    public class UnitTest1
    {
        [Test]//CCL
        public void TestSort()
        {
            Sort sort = new Sort();
            string[,] scores = new string[2, 2];
            scores[0, 0] = "Testing";
            scores[0, 1] = "100";
            scores[1, 0] = "Testing1";
            scores[1, 1] = "200";
            string[,] sort_scores = sort.sortscore(scores);
            Assert.AreEqual(sort_scores[1, 1], "100");
        }
    }
}
