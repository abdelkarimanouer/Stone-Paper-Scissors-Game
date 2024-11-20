namespace StonePaperScissors
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnStone = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbPWon = new System.Windows.Forms.Label();
            this.lbCWon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.White;
            this.pbPlayer.Image = global::StonePaperScissors.Properties.Resources.question_mark_96;
            this.pbPlayer.Location = new System.Drawing.Point(71, 83);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(163, 130);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 1;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Tag = "?";
            // 
            // pbComputer
            // 
            this.pbComputer.BackColor = System.Drawing.Color.White;
            this.pbComputer.Image = global::StonePaperScissors.Properties.Resources.question_mark_96;
            this.pbComputer.Location = new System.Drawing.Point(428, 83);
            this.pbComputer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(163, 130);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputer.TabIndex = 2;
            this.pbComputer.TabStop = false;
            this.pbComputer.Tag = "?";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::StonePaperScissors.Properties.Resources.clipart942700;
            this.pictureBox3.Location = new System.Drawing.Point(22, 403);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::StonePaperScissors.Properties.Resources.clipart942700;
            this.pictureBox4.Location = new System.Drawing.Point(523, 403);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 97);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Urdu Typesetting", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Urdu Typesetting", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "Computer";
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.Transparent;
            this.btnScissors.BackgroundImage = global::StonePaperScissors.Properties.Resources.Scissors;
            this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScissors.Location = new System.Drawing.Point(20, 19);
            this.btnScissors.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(80, 67);
            this.btnScissors.TabIndex = 10;
            this.btnScissors.Tag = "1";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnStone
            // 
            this.btnStone.BackColor = System.Drawing.Color.Transparent;
            this.btnStone.BackgroundImage = global::StonePaperScissors.Properties.Resources.Stone;
            this.btnStone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStone.Location = new System.Drawing.Point(119, 19);
            this.btnStone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(80, 67);
            this.btnStone.TabIndex = 11;
            this.btnStone.Tag = "2";
            this.btnStone.UseVisualStyleBackColor = false;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.Transparent;
            this.btnPaper.BackgroundImage = global::StonePaperScissors.Properties.Resources.Paper;
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaper.Location = new System.Drawing.Point(228, 19);
            this.btnPaper.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(80, 67);
            this.btnPaper.TabIndex = 12;
            this.btnPaper.Tag = "3";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPaper);
            this.panel1.Controls.Add(this.btnStone);
            this.panel1.Controls.Add(this.btnScissors);
            this.panel1.Location = new System.Drawing.Point(165, 284);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 99);
            this.panel1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lbPWon
            // 
            this.lbPWon.AutoSize = true;
            this.lbPWon.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPWon.Location = new System.Drawing.Point(266, 129);
            this.lbPWon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPWon.Name = "lbPWon";
            this.lbPWon.Size = new System.Drawing.Size(40, 41);
            this.lbPWon.TabIndex = 14;
            this.lbPWon.Text = "0";
            // 
            // lbCWon
            // 
            this.lbCWon.AutoSize = true;
            this.lbCWon.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCWon.Location = new System.Drawing.Point(373, 129);
            this.lbCWon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCWon.Name = "lbCWon";
            this.lbCWon.Size = new System.Drawing.Size(40, 41);
            this.lbCWon.TabIndex = 15;
            this.lbCWon.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "-";
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Urdu Typesetting", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(235, 216);
            this.lbResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(191, 50);
            this.lbResult.TabIndex = 17;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(660, 509);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCWon);
            this.Controls.Add(this.lbPWon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.pbPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stone Paper Scissors Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbPWon;
        private System.Windows.Forms.Label lbCWon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResult;
    }
}

