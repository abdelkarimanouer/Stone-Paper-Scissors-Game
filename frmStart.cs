﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePaperScissors
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Form frmGame = new frmGame();
            frmGame.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
