using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace russianrumble
{
    abstract class Squatter : Entity
    {
        protected int displayX;
        protected int displayY;

        public abstract override void Draw(Graphics graphics);
        public abstract void Move(int direction);

    }
}
