using System;
using System.Windows.Forms;
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

        [Test]//Elaine
        public void TestLife()
        {
            Form1 form = new Form1(); //Create new form
            PictureBox pictureBox1 = form.pictureBox1;
            form.vita = 1;
            form.life();
            Assert.AreEqual(false, pictureBox1.Visible);
        }
        [Test]//Yeat
        public void TestCheatCode()
        {

            Form1 form = new Form1();
            form.checkcheat("SPEEDGOD");
            Assert.AreEqual(true, form.cheatGameSpeed);
            form.checkcheat("GODMODE");
            Assert.AreEqual(true, form.cheatInfiniteLife);
            form.checkcheat("REALGAME");
            Assert.AreEqual(false, form.cheatGameSpeed);
            Assert.AreEqual(false, form.cheatInfiniteLife);

        }

        [Test]//Jasmin
        public void TestMusic()
        {
            System.Media.SoundPlayer test = new System.Media.SoundPlayer();
            test.SoundLocation = "mainmenu.wav";
            Assert.AreEqual(test.SoundLocation, "mainmenu.wav");
        }
    }
}
