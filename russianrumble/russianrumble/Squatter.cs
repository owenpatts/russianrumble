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
        protected int x;
        protected int y;
        public abstract void Draw(Graphics graphics);
        public abstract void Move(int x, int y);

    }
}
