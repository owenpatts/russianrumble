using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace russianrumble
{
    public partial class Form1 : Form
    {
        static Graphics g;
        Game game = new Game();
        int mousePosX;
        int mousePosY;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            timer1.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            game.Draw(e.Graphics);
            game.Update(mousePosX, mousePosY, e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            game.Click(e.X, e.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosX = e.X;
            mousePosY = e.Y;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case 'w':
                    if (game.player.GetY() >= 0)
                    {
                        game.player.Move(Direction.UP, game.world);
                    }
                    break;
                case 's':
                    if (game.player.GetY() >= 0)
                    {
                        game.player.Move(Direction.DOWN, game.world);
                    }
                    break;
                case 'a':
                    if (game.player.GetY() >= 0)
                    {
                        game.player.Move(Direction.LEFT, game.world);
                    }
                    break;
                case 'd':
                    if (game.player.GetY() >= 0)
                    {
                        game.player.Move(Direction.RIGHT, game.world);
                    }
                    break;
            }
        }
    }
}