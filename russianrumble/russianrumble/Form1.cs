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
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            GameProperties.screenHeight = this.Height;
            GameProperties.screenWidth = this.Width;
            timer1.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            game.Draw(e.Graphics);
            game.Update(mousePosX, mousePosY);
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
            game.HandleMouseClick();
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
            game.HandleKeyPress(e.KeyChar);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            GameProperties.screenHeight = this.Height;
            GameProperties.screenWidth = this.Width;
        }
    }
}