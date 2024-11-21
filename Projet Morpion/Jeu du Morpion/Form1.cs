using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_du_Morpion
{
    public partial class Form1 : Form
    {
        Boolean Checker;
        int PlusOne;

        void BoxNotWork()
        {
            Box1_1.Enabled = false;
            Box1_2.Enabled = false;
            Box1_3.Enabled = false;
            Box2_1.Enabled = false;
            Box2_2.Enabled = false;
            Box2_3.Enabled = false;
            Box3_1.Enabled = false;
            Box3_2.Enabled = false;
            Box3_3.Enabled = false;
        }

        void BoxWork()
        {
            Box1_1.Enabled = true;
            Box1_2.Enabled = true;
            Box1_3.Enabled = true;
            Box2_1.Enabled = true;
            Box2_2.Enabled = true;
            Box2_3.Enabled = true;
            Box3_1.Enabled = true;
            Box3_2.Enabled = true;
            Box3_3.Enabled = true;
        }

        void ResetBox()
        {
            Box1_1.Image = BoxReset.Image;
            Box1_2.Image = BoxReset.Image;
            Box1_3.Image = BoxReset.Image;
            Box2_1.Image = BoxReset.Image;
            Box2_2.Image = BoxReset.Image;
            Box2_3.Image = BoxReset.Image;
            Box3_1.Image = BoxReset.Image;
            Box3_2.Image = BoxReset.Image;
            Box3_3.Image = BoxReset.Image;

            Box1_1.BackColor = Color.LightGray;
            Box1_2.BackColor = Color.LightGray;
            Box1_3.BackColor = Color.LightGray;
            Box2_1.BackColor = Color.LightGray;
            Box2_2.BackColor = Color.LightGray;
            Box2_3.BackColor = Color.LightGray;
            Box3_1.BackColor = Color.LightGray;
            Box3_2.BackColor = Color.LightGray;
            Box3_3.BackColor = Color.LightGray;
        }

        //Sound Play
        void SoundX()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\userlocal\Documents\GEII\2eme Annee\IG\Projet Morpion\Sounds\SoundX.wav"))
            {
                soundPlayer.Play();
            }
        }
        void SoundO()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\userlocal\Documents\GEII\2eme Annee\IG\Projet Morpion\Sounds\SoundO.wav"))
            {
                soundPlayer.Play();
            }
        }
        void WinnerX()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\userlocal\Documents\GEII\2eme Annee\IG\Projet Morpion\Sounds\WinnerX.wav"))
            {
                soundPlayer.Play();
            }
        }
        void WinnerO()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\userlocal\Documents\GEII\2eme Annee\IG\Projet Morpion\Sounds\WinnerO.wav"))
            {
                soundPlayer.Play();
            }
        }
        void DrawGame()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\userlocal\Documents\GEII\2eme Annee\IG\Projet Morpion\Sounds\DrawGame.wav"))
            {
                soundPlayer.Play();
            }
        }
        
        //Go for Different Forms Show
        void MessageXShow()
        {
            MessageX messageX = new MessageX();
            messageX.ShowDialog();
        }
        void MessageOShow()
        {
            MessageO messageO = new MessageO();
            messageO.ShowDialog();
        }
        void MessageDrawShow()
        {
            MessageDraw messageDraw = new MessageDraw();
            messageDraw.ShowDialog();
        }
        void NewGame()
        {
            NewGame newGame = new NewGame();
            newGame.ShowDialog();
        }
        void ExitGame()
        {
            ExitGame exitGame = new ExitGame();
            exitGame.ShowDialog();
        }
        //That count Score
        void Score()
        {
            //Player X Wins
            if (Box1_1.Image == pictureX.Image && Box1_2.Image == pictureX.Image && Box1_3.Image == pictureX.Image)
            {
                Box1_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box1_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box1_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne+1);
                BoxNotWork();
            }
            else if (Box2_1.Image == pictureX.Image && Box2_2.Image == pictureX.Image && Box2_3.Image == pictureX.Image)
            {
                Box2_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box3_1.Image == pictureX.Image && Box3_2.Image == pictureX.Image && Box3_3.Image == pictureX.Image)
            {
                Box3_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1_1.Image == pictureX.Image && Box2_1.Image == pictureX.Image && Box3_1.Image == pictureX.Image)
            {
                Box1_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1_2.Image == pictureX.Image && Box2_2.Image == pictureX.Image && Box3_2.Image == pictureX.Image)
            {
                Box1_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1_3.Image == pictureX.Image && Box2_3.Image == pictureX.Image && Box3_3.Image == pictureX.Image)
            {
                Box1_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1_1.Image == pictureX.Image && Box2_2.Image == pictureX.Image && Box3_3.Image == pictureX.Image)
            {
                Box1_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1_3.Image == pictureX.Image && Box2_2.Image == pictureX.Image && Box3_1.Image == pictureX.Image)
            {
                Box1_3.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box2_2.BackColor = Color.FromArgb(20, 250, 49, 74);
                Box3_1.BackColor = Color.FromArgb(20, 250, 49, 74);
                WinnerX();
                MessageXShow();
                PlusOne = int.Parse(labelPoint_X.Text);
                labelPoint_X.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            //Player O wins
            if (Box1_1.Image == pictureO.Image && Box1_2.Image == pictureO.Image && Box1_3.Image == pictureO.Image)
            {
                Box1_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box1_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box1_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box2_1.Image == pictureO.Image && Box2_2.Image == pictureO.Image && Box2_3.Image == pictureO.Image)
            {
                Box2_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box3_1.Image == pictureO.Image && Box3_2.Image == pictureO.Image && Box3_3.Image == pictureO.Image)
            {
                Box3_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1_1.Image == pictureO.Image && Box2_1.Image == pictureO.Image && Box3_1.Image == pictureO.Image)
            {
                Box1_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1_2.Image == pictureO.Image && Box2_2.Image == pictureO.Image && Box3_2.Image == pictureO.Image)
            {
                Box1_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1_3.Image == pictureO.Image && Box2_3.Image == pictureO.Image && Box3_3.Image == pictureO.Image)
            {
                Box1_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1_1.Image == pictureO.Image && Box2_2.Image == pictureO.Image && Box3_3.Image == pictureO.Image)
            {
                Box1_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            else if (Box1_3.Image == pictureO.Image && Box2_2.Image == pictureO.Image && Box3_1.Image == pictureO.Image)
            {
                Box1_3.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box2_2.BackColor = Color.FromArgb(20, 0, 185, 255);
                Box3_1.BackColor = Color.FromArgb(20, 0, 185, 255);
                WinnerO();
                MessageOShow();
                PlusOne = int.Parse(labelPoints_O.Text);
                labelPoints_O.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }
            //DrawGame
            else (Box1_1.Image != BoxReset.Image && Box1_2.Image != BoxReset.Image && Box1_3.Image != BoxReset.Image && Box2_1.Image != BoxReset.Image && Box2_2.Image != BoxReset.Image && Box2_3.Image != BoxReset.Image && Box3_1.Image != BoxReset.Image && Box3_2.Image != BoxReset.Image && Box3_3.Image != BoxReset.Image)
            {
                DrawGame();
                MessageDrawShow();
                PlusOne = int.Parse(labelPoint_Morpion.Text);
                labelPoint_Morpion.Text = Convert.ToString(PlusOne + 1);
                BoxNotWork();
            }

        }
        //Create Function for Picture Work Button
        void ButtonBox1_1()
        {
            if (Checker == false)
            {
                SoundX();
                Box1_1.Image = pictureX.Image; 
                Checker = true;

            }
            else
            {
                Box1_1.Image = pictureO.Image;
                SoundO();
                Checker = false;
            }
            Score();
            Box1_1.Enabled = false;

        }
        void ButtonBox1_2()
        {
            if (Checker == false)
            {
                Box1_2.Image = pictureX.Image;
                SoundX();
                Checker = true;

            }
            else
            {
                Box1_2.Image = pictureO.Image;
                SoundO();
                Checker = false;
            }
            Score();
            Box1_2.Enabled = false;

        }
        void ButtonBox1_3()
        {
            if (Checker == false)
            {
                Box1_3.Image = pictureX.Image;
                SoundX();
                Checker = true;

            }
            else
            {
                Box1_3.Image = pictureO.Image;
                SoundO();
                Checker = false;
            }
            Score();
            Box1_3.Enabled = false;

        }
        void ButtonBox2_1()
        {
            if (Checker == false)
            {
                Box2_1.Image = pictureX.Image;
                SoundX();
                Checker = true;

            }
            else
            {
                Box2_1.Image = pictureO.Image;
                SoundO();
                Checker = false;
            }
            Score();
            Box2_1.Enabled = false;

        }
        void ButtonBox2_2()
        {
            if (Checker == false)
            {
                Box2_2.Image = pictureX.Image;
                SoundX();
                Checker = true;

            }
            else
            {
                Box2_2.Image = pictureO.Image;
                SoundO();
                Checker = false;
            }
            Score();
            Box2_2.Enabled = false;

        }
        void ButtonBox2_3()
        {
            if (Checker == false)
            {
                Box2_3.Image = pictureX.Image;
                SoundX();
                Checker = true;

            }
            else
            {
                Box2_3.Image = pictureO.Image;
                SoundO();
                Checker = false;
            }
            Score();
            Box2_3.Enabled = false;

        }
        void ButtonBox3_1()
        {
            if (Checker == false)
            {
                Box3_1.Image = pictureX.Image;
                SoundX();
                Checker = true;

            }
            else
            {
                Box3_1.Image = pictureO.Image;
                SoundO();
                Checker = false;
            }
            Score();
            Box3_1.Enabled = false;

        }
        void ButtonBox3_2()
        {
            if (Checker == false)
            {
                Box3_2.Image = pictureX.Image;
                SoundX();
                Checker = true;

            }
            else
            {
                Box3_2.Image = pictureO.Image;
                SoundO();
                Checker = false;
            }
            Score();
            Box3_2.Enabled = false;

        }
        void ButtonBox3_3()
        {
            if (Checker == false)
            {
                Box3_3.Image = pictureX.Image;
                SoundX();
                Checker = true;

            }
            else
            {
                Box3_3.Image = pictureO.Image;
                SoundO();
                Checker = false;
            }
            Score();
            Box3_3.Enabled = false;

        }


        public Form1()
        {
            InitializeComponent();
        }

        // Custom Close and Minimize Button
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureFermer_Click(object sender, EventArgs e)
        {
            ExitGame();
        }

        private void pictureMinimizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Box1_1_Click(object sender, EventArgs e)
        {
            ButtonBox1_1();
        }

        private void Box1_2_Click(object sender, EventArgs e)
        {
            ButtonBox1_2();
        }

        private void Box1_3_Click(object sender, EventArgs e)
        {
            ButtonBox1_3();
        }

        private void Box2_1_Click(object sender, EventArgs e)
        {
            ButtonBox2_1();
        }

        private void Box2_2_Click(object sender, EventArgs e)
        {
            ButtonBox2_2();
        }

        private void Box2_3_Click(object sender, EventArgs e)
        {
            ButtonBox2_3();
        }

        private void Box3_1_Click(object sender, EventArgs e)
        {
            ButtonBox3_1();
        }

        private void Box3_2_Click(object sender, EventArgs e)
        {
           ButtonBox3_2();
        }

        private void Box3_3_Click(object sender, EventArgs e)
        {
            ButtonBox3_3();
        }

        private void buttonNouveauJeu_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            BoxWork();
            ResetBox();
        }
    }
}
