using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russianrumble
{
    class ScrollButtonUp : Button
    {

        public ScrollButtonUp(int originX, int originY, int size) : base(originX, originX, size) { }

        public override void Do(World world)
        {
            throw new NotImplementedException();
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Brushes.AliceBlue, 2), this.bounds);
        }
    }
}
