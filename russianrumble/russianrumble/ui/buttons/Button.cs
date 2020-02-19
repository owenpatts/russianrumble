using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russianrumble
{
    class Button
    {
        public delegate void Action(World world);
        Action action;
        private int height;
        private int width;
        private int originX;
        private int originY;
        protected Rectangle bounds;

        public Button(int originX, int originY, int size, Action delegateFunction)
        {
            this.originX = originX;
            this.originY = originY;
            this.width = size;
            this.height = size;
            this.bounds = new Rectangle(originX, originY, width, height);
            action = new Action(delegateFunction);
        }

        public Button(int originX, int originY, int width, int height)
        {
            this.originX = originX;
            this.originY = originY;
            this.width = width;
            this.height = height;
            this.bounds = new Rectangle(originX, originY, width, height);
        }

        public void onClick(World world, int mousePosX, int mousePosY)
        {
            if (bounds.Contains(new Point(mousePosX, mousePosY)))
            {
                Do(world);
            }
        }

        public void Do(World world)
        {
            action(world);
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Brushes.Black, 2), bounds);
        }
    }
}
