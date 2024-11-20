using StonePaperScissors.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePaperScissors
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        private byte PWon = 0;
        private byte CWon = 0;

        private void WhoWon()
        {
            if ( Convert.ToString(pbPlayer.Tag) == Convert.ToString(pbComputer.Tag))
            {
                lbResult.ForeColor = Color.Yellow;
                lbResult.Text = "Draw";
                return;
            }

            if (Convert.ToString(pbPlayer.Tag) == "Scissors")
            {
                if (Convert.ToString(pbComputer.Tag) == "Paper")
                {
                    PWon++;
                    lbResult.ForeColor = Color.Green;
                    lbResult.Text = "Player Won";
                    lbPWon.Text = PWon.ToString();
                }
                else
                {
                    CWon++;
                    lbResult.ForeColor = Color.Red;
                    lbResult.Text = "Computer Won";
                    lbCWon.Text = CWon.ToString();
                }
            }

            else if(Convert.ToString(pbPlayer.Tag) == "Paper")
            {
                if (Convert.ToString(pbComputer.Tag) == "Stone")
                {
                    PWon++;
                    lbResult.ForeColor = Color.Green;
                    lbResult.Text = "Player Won";
                    lbPWon.Text = PWon.ToString();
                }
                else
                {
                    CWon++;
                    lbResult.ForeColor = Color.Red;
                    lbResult.Text = "Computer Won";
                    lbCWon.Text = CWon.ToString();
                }
            }

            else if (Convert.ToString(pbPlayer.Tag) == "Stone")
            {
                if (Convert.ToString(pbComputer.Tag) == "Scissors")
                {
                    PWon++;
                    lbResult.ForeColor = Color.Green;
                    lbResult.Text = "Player Won";
                    lbPWon.Text = PWon.ToString();
                }
                else
                {
                    CWon++;
                    lbResult.ForeColor = Color.Red;
                    lbResult.Text = "Computer Won";
                    lbCWon.Text = CWon.ToString();
                }
            }

        }

        private void ComputerChoose()
        {
            Random rnd = new Random();
            int Choose = rnd.Next(1, 4);


            if (Choose == Convert.ToInt16(btnPaper.Tag))
            {
                pbComputer.Image = Resources.Paper;
                pbComputer.Tag = "Paper";
            }

            if (Choose == Convert.ToInt16(btnScissors.Tag))
            {
                pbComputer.Image = Resources.Scissors;
                pbComputer.Tag = "Scissors";
            }

            if (Choose == Convert.ToInt16(btnStone.Tag))
            {
                pbComputer.Image = Resources.Stone;
                pbComputer.Tag = "Stone";
            }


        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            pbPlayer.Image = Resources.Scissors;
            pbPlayer.Tag = "Scissors";
            ComputerChoose();
            WhoWon();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            pbPlayer.Image = Resources.Stone;
            pbPlayer.Tag = "Stone";
            ComputerChoose();
            WhoWon();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            pbPlayer.Image = Resources.Paper;
            pbPlayer.Tag = "Paper";
            ComputerChoose();
            WhoWon();
        }
    }
}
