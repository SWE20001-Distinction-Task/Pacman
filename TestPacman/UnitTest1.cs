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

            Boolean cheatGameSpeed = false, cheatInfiniteLife = false;

            string cheatCode = "SPEEDGOD";
            //SPEEDGOD makes the game faster
            if (cheatCode == "SPEEDGOD")
                cheatGameSpeed = true;
            //GODMODE makes the pacman never decrease in current number of life
            //In another word it means infinite life
            else if (cheatCode == "GODMODE")
                cheatInfiniteLife = true;
            //REALGAME cancel the cheat code
            else if (cheatCode == "REALGAME")
            {
                cheatGameSpeed = false;
                cheatInfiniteLife = false;
            }
            Assert.AreEqual(true, cheatGameSpeed);
            cheatCode = "REALGAME";

            if (cheatCode == "SPEEDGOD")
                cheatGameSpeed = true;
            //GODMODE makes the pacman never decrease in current number of life
            //In another word it means infinite life
            else if (cheatCode == "GODMODE")
                cheatInfiniteLife = true;
            //REALGAME cancel the cheat code
            else if (cheatCode == "REALGAME")
            {
                cheatGameSpeed = false;
                cheatInfiniteLife = false;
            }
            Assert.AreEqual(false, cheatGameSpeed);

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
