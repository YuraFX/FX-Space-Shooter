//  Foobar is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  Foobar is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with Foobar.  If not, see <http://www.gnu.org/licenses/>.

namespace FX_Space_Shooter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.BulletsMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblSc = new System.Windows.Forms.Label();
            this.lblLive = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblYura = new System.Windows.Forms.Label();
            this.pbGitHub = new System.Windows.Forms.PictureBox();
            this.gameLogo = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.lblGO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 10;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 10;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // BulletsMoveTimer
            // 
            this.BulletsMoveTimer.Enabled = true;
            this.BulletsMoveTimer.Interval = 10;
            this.BulletsMoveTimer.Tick += new System.EventHandler(this.BulletsMoveTimer_Tick);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(61, 20);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score:";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.Color.Transparent;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLives.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblLives.Location = new System.Drawing.Point(12, 33);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(55, 20);
            this.lblLives.TabIndex = 8;
            this.lblLives.Text = "Lives:";
            // 
            // lblSc
            // 
            this.lblSc.BackColor = System.Drawing.Color.Transparent;
            this.lblSc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSc.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblSc.Location = new System.Drawing.Point(73, 9);
            this.lblSc.Name = "lblSc";
            this.lblSc.Size = new System.Drawing.Size(499, 20);
            this.lblSc.TabIndex = 9;
            this.lblSc.Text = "00";
            // 
            // lblLive
            // 
            this.lblLive.AutoSize = true;
            this.lblLive.BackColor = System.Drawing.Color.Transparent;
            this.lblLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLive.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblLive.Location = new System.Drawing.Point(73, 33);
            this.lblLive.Name = "lblLive";
            this.lblLive.Size = new System.Drawing.Size(29, 20);
            this.lblLive.TabIndex = 10;
            this.lblLive.Text = "03";
            // 
            // lblDev
            // 
            this.lblDev.BackColor = System.Drawing.Color.Transparent;
            this.lblDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDev.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblDev.Location = new System.Drawing.Point(21, 68);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(542, 20);
            this.lblDev.TabIndex = 14;
            this.lblDev.Text = "00";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.BackColor = System.Drawing.Color.Transparent;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblR.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblR.Location = new System.Drawing.Point(341, 33);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(231, 20);
            this.lblR.TabIndex = 15;
            this.lblR.Text = "Press R to restart the game";
            // 
            // lblYura
            // 
            this.lblYura.BackColor = System.Drawing.Color.Transparent;
            this.lblYura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYura.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblYura.Location = new System.Drawing.Point(581, 172);
            this.lblYura.Name = "lblYura";
            this.lblYura.Size = new System.Drawing.Size(235, 72);
            this.lblYura.TabIndex = 17;
            this.lblYura.Text = "This game was written by Yuri Konyshev aka Yura_FX in C#.";
            this.lblYura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbGitHub
            // 
            this.pbGitHub.Image = global::FX_Space_Shooter.Properties.Resources.btnGit;
            this.pbGitHub.Location = new System.Drawing.Point(585, 547);
            this.pbGitHub.Name = "pbGitHub";
            this.pbGitHub.Size = new System.Drawing.Size(231, 41);
            this.pbGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbGitHub.TabIndex = 18;
            this.pbGitHub.TabStop = false;
            this.pbGitHub.Click += new System.EventHandler(this.pbGitHub_Click);
            // 
            // gameLogo
            // 
            this.gameLogo.BackColor = System.Drawing.Color.Transparent;
            this.gameLogo.Image = global::FX_Space_Shooter.Properties.Resources.gameLogo;
            this.gameLogo.Location = new System.Drawing.Point(581, 53);
            this.gameLogo.Name = "gameLogo";
            this.gameLogo.Size = new System.Drawing.Size(235, 116);
            this.gameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gameLogo.TabIndex = 16;
            this.gameLogo.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::FX_Space_Shooter.Properties.Resources.Player_spaceship;
            this.Player.Location = new System.Drawing.Point(266, 536);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(52, 32);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // pb8
            // 
            this.pb8.BackColor = System.Drawing.Color.Transparent;
            this.pb8.Image = global::FX_Space_Shooter.Properties.Resources.Minip;
            this.pb8.Location = new System.Drawing.Point(180, 32);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(30, 18);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb8.TabIndex = 13;
            this.pb8.TabStop = false;
            // 
            // pb7
            // 
            this.pb7.BackColor = System.Drawing.Color.Transparent;
            this.pb7.Image = global::FX_Space_Shooter.Properties.Resources.Minip;
            this.pb7.Location = new System.Drawing.Point(144, 32);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(30, 18);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb7.TabIndex = 12;
            this.pb7.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.BackColor = System.Drawing.Color.Transparent;
            this.pb6.Image = global::FX_Space_Shooter.Properties.Resources.Minip;
            this.pb6.Location = new System.Drawing.Point(108, 32);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(30, 18);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb6.TabIndex = 11;
            this.pb6.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::FX_Space_Shooter.Properties.Resources.NewTexture3;
            this.pb2.Location = new System.Drawing.Point(12, 62);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(560, 3);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 5;
            this.pb2.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::FX_Space_Shooter.Properties.Resources.NewTexture3;
            this.pb4.Location = new System.Drawing.Point(569, 62);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(3, 526);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 4;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::FX_Space_Shooter.Properties.Resources.NewTexture3;
            this.pb3.Location = new System.Drawing.Point(12, 62);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(3, 526);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 3;
            this.pb3.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::FX_Space_Shooter.Properties.Resources.NewTexture3;
            this.pb1.Location = new System.Drawing.Point(12, 586);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(560, 3);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(12, 0);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(560, 65);
            this.pb5.TabIndex = 6;
            this.pb5.TabStop = false;
            // 
            // lblGO
            // 
            this.lblGO.BackColor = System.Drawing.Color.Transparent;
            this.lblGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGO.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblGO.Location = new System.Drawing.Point(21, 316);
            this.lblGO.Name = "lblGO";
            this.lblGO.Size = new System.Drawing.Size(542, 20);
            this.lblGO.TabIndex = 19;
            this.lblGO.Text = "Game over";
            this.lblGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(828, 601);
            this.Controls.Add(this.lblGO);
            this.Controls.Add(this.pbGitHub);
            this.Controls.Add(this.lblYura);
            this.Controls.Add(this.gameLogo);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.lblLive);
            this.Controls.Add(this.lblSc);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb5);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FX Space Shooter 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Timer BulletsMoveTimer;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblSc;
        private System.Windows.Forms.Label lblLive;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.PictureBox gameLogo;
        private System.Windows.Forms.Label lblYura;
        private System.Windows.Forms.PictureBox pbGitHub;
        private System.Windows.Forms.Label lblGO;
    }
}

