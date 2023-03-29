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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace FX_Space_Shooter
{
    public partial class Form1 : Form
    {
        int playerSpeed;

        int Score;
        int Lives;
        int Dev;

        PictureBox[] bullets;
        int bulletsSpeed;

        PictureBox[] enemies;
        int enemiesSpeed;

        WindowsMediaPlayer Shoot;
        WindowsMediaPlayer Enemykilled;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shoot = new WindowsMediaPlayer();
            Shoot.URL = "Game resources\\Sounds\\Shoot.mp3";
            Shoot.settings.volume = 5;
            Shoot.controls.stop();

            Enemykilled = new WindowsMediaPlayer();
            Enemykilled.URL = "Game resources\\Sounds\\Enemykilled.mp3";
            Enemykilled.settings.volume = 3;
            Enemykilled.controls.stop();

            playerSpeed = 6;

            Score = 0;
            Lives = 3;

            Dev = 0;
            lblDev.Visible = false;

            lblR.Visible = false;
            lblGO.Visible = false;

            bullets = new PictureBox[1];
            bulletsSpeed = 20;

            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].BorderStyle = BorderStyle.None;
                bullets[i].Size = new Size(3, 15);
                bullets[i].BackColor = Color.White;

                this.Controls.Add(bullets[i]);
            }

            enemies = new PictureBox[40];
            enemiesSpeed = 1;

            Image easyEnemies = Image.FromFile("Game resources\\Assets\\Enemy.png");

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].SizeMode = PictureBoxSizeMode.AutoSize;
                enemies[i].BackColor = Color.Transparent;
                enemies[i].Image = easyEnemies;

                this.Controls.Add(enemies[i]);
            }

            enemies[0].Location = new Point(95, 91);
            enemies[1].Location = new Point(95, 129);
            enemies[2].Location = new Point(95, 167);
            enemies[3].Location = new Point(95, 205);
            enemies[4].Location = new Point(95, 243);

            enemies[5].Location = new Point(145, 91);
            enemies[6].Location = new Point(145, 129);
            enemies[7].Location = new Point(145, 167);
            enemies[8].Location = new Point(145, 205);
            enemies[9].Location = new Point(145, 243);

            enemies[10].Location = new Point(195, 91);
            enemies[11].Location = new Point(195, 129);
            enemies[12].Location = new Point(195, 167);
            enemies[13].Location = new Point(195, 205);
            enemies[14].Location = new Point(195, 243);

            enemies[15].Location = new Point(245, 91);
            enemies[16].Location = new Point(245, 129);
            enemies[17].Location = new Point(245, 167);
            enemies[18].Location = new Point(245, 205);
            enemies[19].Location = new Point(245, 243);

            enemies[20].Location = new Point(295, 91);
            enemies[21].Location = new Point(295, 129);
            enemies[22].Location = new Point(295, 167);
            enemies[23].Location = new Point(295, 205);
            enemies[24].Location = new Point(295, 243);

            enemies[25].Location = new Point(345, 91);
            enemies[26].Location = new Point(345, 129);
            enemies[27].Location = new Point(345, 167);
            enemies[28].Location = new Point(345, 205);
            enemies[29].Location = new Point(345, 243);

            enemies[30].Location = new Point(395, 91);
            enemies[31].Location = new Point(395, 129);
            enemies[32].Location = new Point(395, 167);
            enemies[33].Location = new Point(395, 205);
            enemies[34].Location = new Point(395, 243);

            enemies[35].Location = new Point(445, 91);
            enemies[36].Location = new Point(445, 129);
            enemies[37].Location = new Point(445, 167);
            enemies[38].Location = new Point(445, 205);
            enemies[39].Location = new Point(445, 243);
        }

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 20)
            {
                Player.Left -= playerSpeed;
            }
        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left < 510)
            {
                Player.Left += playerSpeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                LeftMoveTimer.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                RightMoveTimer.Start();
            }

            if (e.KeyCode == Keys.Space)
            {
                for (int i = 0; i < bullets.Length; i++)
                {
                    Intersect();

                    if (bullets[i].Top < 0)
                    {
                        Shoot.controls.play();

                        bullets[i].Location = new Point(Player.Location.X + 25 + i * 0, Player.Location.Y - 20);
                    }
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.R)
            {
                if (lblR.Visible == true)
                {
                    lblR.Visible = false;
                    lblGO.Visible = false;

                    Score *= 0;
                    lblSc.Text = "00";

                    Lives = 3;
                    lblLive.Text = "03";

                    Dev *= 0;
                    lblDev.Text = "00";

                    MoveEnemiesTimer.Enabled = true;
                    BulletsMoveTimer.Enabled = true;

                    pb6.Visible = true;
                    pb7.Visible = true;
                    pb8.Visible = true;

                    Player.SizeMode = PictureBoxSizeMode.AutoSize;
                    Player.Location = new Point(266, 536);
                    Player.Visible = true;

                    enemies[0].Location = new Point(95, 91);
                    enemies[1].Location = new Point(95, 129);
                    enemies[2].Location = new Point(95, 167);
                    enemies[3].Location = new Point(95, 205);
                    enemies[4].Location = new Point(95, 243);

                    enemies[5].Location = new Point(145, 91);
                    enemies[6].Location = new Point(145, 129);
                    enemies[7].Location = new Point(145, 167);
                    enemies[8].Location = new Point(145, 205);
                    enemies[9].Location = new Point(145, 243);

                    enemies[10].Location = new Point(195, 91);
                    enemies[11].Location = new Point(195, 129);
                    enemies[12].Location = new Point(195, 167);
                    enemies[13].Location = new Point(195, 205);
                    enemies[14].Location = new Point(195, 243);

                    enemies[15].Location = new Point(245, 91);
                    enemies[16].Location = new Point(245, 129);
                    enemies[17].Location = new Point(245, 167);
                    enemies[18].Location = new Point(245, 205);
                    enemies[19].Location = new Point(245, 243);

                    enemies[20].Location = new Point(295, 91);
                    enemies[21].Location = new Point(295, 129);
                    enemies[22].Location = new Point(295, 167);
                    enemies[23].Location = new Point(295, 205);
                    enemies[24].Location = new Point(295, 243);

                    enemies[25].Location = new Point(345, 91);
                    enemies[26].Location = new Point(345, 129);
                    enemies[27].Location = new Point(345, 167);
                    enemies[28].Location = new Point(345, 205);
                    enemies[29].Location = new Point(345, 243);

                    enemies[30].Location = new Point(395, 91);
                    enemies[31].Location = new Point(395, 129);
                    enemies[32].Location = new Point(395, 167);
                    enemies[33].Location = new Point(395, 205);
                    enemies[34].Location = new Point(395, 243);

                    enemies[35].Location = new Point(445, 91);
                    enemies[36].Location = new Point(445, 129);
                    enemies[37].Location = new Point(445, 167);
                    enemies[38].Location = new Point(445, 205);
                    enemies[39].Location = new Point(445, 243);

                    enemies[0].Visible = true;
                    enemies[1].Visible = true;
                    enemies[2].Visible = true;
                    enemies[3].Visible = true;
                    enemies[4].Visible = true;

                    enemies[5].Visible = true;
                    enemies[6].Visible = true;
                    enemies[7].Visible = true;
                    enemies[8].Visible = true;
                    enemies[9].Visible = true;

                    enemies[10].Visible = true;
                    enemies[11].Visible = true;
                    enemies[12].Visible = true;
                    enemies[13].Visible = true;
                    enemies[14].Visible = true;

                    enemies[15].Visible = true;
                    enemies[16].Visible = true;
                    enemies[17].Visible = true;
                    enemies[18].Visible = true;
                    enemies[19].Visible = true;

                    enemies[20].Visible = true;
                    enemies[21].Visible = true;
                    enemies[22].Visible = true;
                    enemies[23].Visible = true;
                    enemies[24].Visible = true;

                    enemies[25].Visible = true;
                    enemies[26].Visible = true;
                    enemies[27].Visible = true;
                    enemies[28].Visible = true;
                    enemies[29].Visible = true;

                    enemies[30].Visible = true;
                    enemies[31].Visible = true;
                    enemies[32].Visible = true;
                    enemies[33].Visible = true;
                    enemies[34].Visible = true;

                    enemies[35].Visible = true;
                    enemies[36].Visible = true;
                    enemies[37].Visible = true;
                    enemies[38].Visible = true;
                    enemies[39].Visible = true;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            LeftMoveTimer.Stop();
            RightMoveTimer.Stop();
        }

        private void BulletsMoveTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i].Top -= bulletsSpeed;
            }
        }

        private void MoveEnemiesTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemiesSpeed);
        }

        private void MoveEnemies(PictureBox[] enemies, int speed)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Top += speed;

                Intersect();
            }
        }

        private void Intersect()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (bullets[0].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    Enemykilled.controls.play();

                    Score += 5;
                    lblSc.Text = (Score < 10) ? "0" + Score.ToString() : Score.ToString();

                    Dev += 1;
                    lblDev.Text = (Dev < 10) ? "0" + Dev.ToString() : Dev.ToString();

                    enemies[i].Location = new Point(1500, 1500);
                    bullets[0].Location = new Point(2000, Player.Location.Y - 20);

                    if (Dev % 40 == 0)
                    {
                        Dev *= 0;
                        lblDev.Text = "00";

                        enemies[0].Location = new Point(95, 91);
                        enemies[1].Location = new Point(95, 129);
                        enemies[2].Location = new Point(95, 167);
                        enemies[3].Location = new Point(95, 205);
                        enemies[4].Location = new Point(95, 243);

                        enemies[5].Location = new Point(145, 91);
                        enemies[6].Location = new Point(145, 129);
                        enemies[7].Location = new Point(145, 167);
                        enemies[8].Location = new Point(145, 205);
                        enemies[9].Location = new Point(145, 243);

                        enemies[10].Location = new Point(195, 91);
                        enemies[11].Location = new Point(195, 129);
                        enemies[12].Location = new Point(195, 167);
                        enemies[13].Location = new Point(195, 205);
                        enemies[14].Location = new Point(195, 243);

                        enemies[15].Location = new Point(245, 91);
                        enemies[16].Location = new Point(245, 129);
                        enemies[17].Location = new Point(245, 167);
                        enemies[18].Location = new Point(245, 205);
                        enemies[19].Location = new Point(245, 243);

                        enemies[20].Location = new Point(295, 91);
                        enemies[21].Location = new Point(295, 129);
                        enemies[22].Location = new Point(295, 167);
                        enemies[23].Location = new Point(295, 205);
                        enemies[24].Location = new Point(295, 243);

                        enemies[25].Location = new Point(345, 91);
                        enemies[26].Location = new Point(345, 129);
                        enemies[27].Location = new Point(345, 167);
                        enemies[28].Location = new Point(345, 205);
                        enemies[29].Location = new Point(345, 243);

                        enemies[30].Location = new Point(395, 91);
                        enemies[31].Location = new Point(395, 129);
                        enemies[32].Location = new Point(395, 167);
                        enemies[33].Location = new Point(395, 205);
                        enemies[34].Location = new Point(395, 243);

                        enemies[35].Location = new Point(445, 91);
                        enemies[36].Location = new Point(445, 129);
                        enemies[37].Location = new Point(445, 167);
                        enemies[38].Location = new Point(445, 205);
                        enemies[39].Location = new Point(445, 243);
                    }
                }

                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    enemies[0].Location = new Point(95, 91);
                    enemies[1].Location = new Point(95, 129);
                    enemies[2].Location = new Point(95, 167);
                    enemies[3].Location = new Point(95, 205);
                    enemies[4].Location = new Point(95, 243);

                    enemies[5].Location = new Point(145, 91);
                    enemies[6].Location = new Point(145, 129);
                    enemies[7].Location = new Point(145, 167);
                    enemies[8].Location = new Point(145, 205);
                    enemies[9].Location = new Point(145, 243);

                    enemies[10].Location = new Point(195, 91);
                    enemies[11].Location = new Point(195, 129);
                    enemies[12].Location = new Point(195, 167);
                    enemies[13].Location = new Point(195, 205);
                    enemies[14].Location = new Point(195, 243);

                    enemies[15].Location = new Point(245, 91);
                    enemies[16].Location = new Point(245, 129);
                    enemies[17].Location = new Point(245, 167);
                    enemies[18].Location = new Point(245, 205);
                    enemies[19].Location = new Point(245, 243);

                    enemies[20].Location = new Point(295, 91);
                    enemies[21].Location = new Point(295, 129);
                    enemies[22].Location = new Point(295, 167);
                    enemies[23].Location = new Point(295, 205);
                    enemies[24].Location = new Point(295, 243);

                    enemies[25].Location = new Point(345, 91);
                    enemies[26].Location = new Point(345, 129);
                    enemies[27].Location = new Point(345, 167);
                    enemies[28].Location = new Point(345, 205);
                    enemies[29].Location = new Point(345, 243);

                    enemies[30].Location = new Point(395, 91);
                    enemies[31].Location = new Point(395, 129);
                    enemies[32].Location = new Point(395, 167);
                    enemies[33].Location = new Point(395, 205);
                    enemies[34].Location = new Point(395, 243);

                    enemies[35].Location = new Point(445, 91);
                    enemies[36].Location = new Point(445, 129);
                    enemies[37].Location = new Point(445, 167);
                    enemies[38].Location = new Point(445, 205);
                    enemies[39].Location = new Point(445, 243);

                    Lives -= 1;
                    lblLive.Text = (Lives < 10) ? "0" + Lives.ToString() : Lives.ToString();

                    Dev *= 0;
                    lblDev.Text = "00";

                    if (lblLive.Text == "02")
                    {
                        pb8.Visible = false;
                    }

                    if (lblLive.Text == "01")
                    {
                        pb7.Visible = false;
                    }

                    if (lblLive.Text == "00")
                    {
                        lblR.Visible = true;
                        lblGO.Visible = true;

                        pb6.Visible = false;

                        enemies[0].Visible = false;
                        enemies[1].Visible = false;
                        enemies[2].Visible = false;
                        enemies[3].Visible = false;
                        enemies[4].Visible = false;

                        enemies[5].Visible = false;
                        enemies[6].Visible = false;
                        enemies[7].Visible = false;
                        enemies[8].Visible = false;
                        enemies[9].Visible = false;

                        enemies[10].Visible = false;
                        enemies[11].Visible = false;
                        enemies[12].Visible = false;
                        enemies[13].Visible = false;
                        enemies[14].Visible = false;

                        enemies[15].Visible = false;
                        enemies[16].Visible = false;
                        enemies[17].Visible = false;
                        enemies[18].Visible = false;
                        enemies[19].Visible = false;

                        enemies[20].Visible = false;
                        enemies[21].Visible = false;
                        enemies[22].Visible = false;
                        enemies[23].Visible = false;
                        enemies[24].Visible = false;

                        enemies[25].Visible = false;
                        enemies[26].Visible = false;
                        enemies[27].Visible = false;
                        enemies[28].Visible = false;
                        enemies[29].Visible = false;

                        enemies[30].Visible = false;
                        enemies[31].Visible = false;
                        enemies[32].Visible = false;
                        enemies[33].Visible = false;
                        enemies[34].Visible = false;

                        enemies[35].Visible = false;
                        enemies[36].Visible = false;
                        enemies[37].Visible = false;
                        enemies[38].Visible = false;
                        enemies[39].Visible = false;

                        MoveEnemiesTimer.Enabled = false;
                        BulletsMoveTimer.Enabled = false;

                        Player.Visible = false;
                    }

                    Player.SizeMode = PictureBoxSizeMode.AutoSize;
                    Player.Location = new Point(266, 536);                    
                }

                if (pb1.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    lblR.Visible = true;
                    lblGO.Visible = true;

                    enemies[0].Visible = false;
                    enemies[1].Visible = false;
                    enemies[2].Visible = false;
                    enemies[3].Visible = false;
                    enemies[4].Visible = false;

                    enemies[5].Visible = false;
                    enemies[6].Visible = false;
                    enemies[7].Visible = false;
                    enemies[8].Visible = false;
                    enemies[9].Visible = false;

                    enemies[10].Visible = false;
                    enemies[11].Visible = false;
                    enemies[12].Visible = false;
                    enemies[13].Visible = false;
                    enemies[14].Visible = false;

                    enemies[15].Visible = false;
                    enemies[16].Visible = false;
                    enemies[17].Visible = false;
                    enemies[18].Visible = false;
                    enemies[19].Visible = false;

                    enemies[20].Visible = false;
                    enemies[21].Visible = false;
                    enemies[22].Visible = false;
                    enemies[23].Visible = false;
                    enemies[24].Visible = false;

                    enemies[25].Visible = false;
                    enemies[26].Visible = false;
                    enemies[27].Visible = false;
                    enemies[28].Visible = false;
                    enemies[29].Visible = false;

                    enemies[30].Visible = false;
                    enemies[31].Visible = false;
                    enemies[32].Visible = false;
                    enemies[33].Visible = false;
                    enemies[34].Visible = false;

                    enemies[35].Visible = false;
                    enemies[36].Visible = false;
                    enemies[37].Visible = false;
                    enemies[38].Visible = false;
                    enemies[39].Visible = false;

                    MoveEnemiesTimer.Enabled = false;
                    BulletsMoveTimer.Enabled = false;

                    Player.Visible = false;
                }
            }
        }

        private void pbGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/YuraFX");
        }       
    }
}
