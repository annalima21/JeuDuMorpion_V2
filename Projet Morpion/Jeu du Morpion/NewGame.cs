﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_du_Morpion
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void labelNewGame_Click(object sender, EventArgs e)
        {

        }
    }
}
