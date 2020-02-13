using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace russianrumble
{
    abstract class Squatter
    {
        protected int displayX;
        protected int displayY;
        protected int x;
        protected int y;
        public abstract void Draw(Graphics graphics);
        public abstract void Move(int direction);

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

    }
}
